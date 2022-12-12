import os
from base64 import b64decode, b64encode
from hashlib import sha3_256
from io import BytesIO
from json import loads
from typing import Optional

import uvicorn
from fastapi import FastAPI
from fastapi.middleware.cors import CORSMiddleware
from fastapi.requests import Request
from fastapi.responses import JSONResponse

from models.errors import (
    AccountDoesNotExistError,
    AccountExistsError,
    InvalidCredentialsError,
    MissingRequiredParameterError,
)
from modules.database import Database
from modules.error_handler import on_error
from modules.OTPGen import check_code, generate_authenticator_setup_qr_code
from modules.utils import generate_qr


class API(FastAPI):
    def __init__(self, *args, **kwargs) -> None:
        super().__init__(*args, **kwargs)
        if not os.path.exists("database.db"):
            open("database.db", "w").close()

        self.db: Database = Database("database.db")


app = API()

app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],
    allow_credentials=True,
    allow_methods=["POST", "GET"],
    allow_headers=["*"],
)

app.add_exception_handler(Exception, on_error)


@app.on_event("startup")
async def startup():
    await app.db.async_init()


@app.post("/register")
async def register(request: Request):
    data = await request.body()
    data = loads(data)

    username = data["email"]
    password = data["password"]
    pass_hash = sha3_256(password.encode()).hexdigest()

    if not await app.db.account_registered(username):

        await app.db.register_customer(username, pass_hash)
        return JSONResponse(
            status_code=200,
            content={
                "status": "success",
                "message": "Registered successfully",
                "success": True,
            },
        )

    else:
        raise AccountExistsError(username)


@app.post("/login")
async def login(request: Request):
    data = await request.body()
    data = loads(data)

    hashed_password = sha3_256(data["password"].encode()).hexdigest()
    username = data.get("username")

    if not await app.db.account_registered(username):
        raise AccountDoesNotExistError(username)

    if await app.db.credentials_match(username, hashed_password):
        customer_id = await app.db.get_customer_id(username)
        return JSONResponse(
            status_code=200,
            content={
                "status": "success",
                "message": "Logged in successfully",
                "success": True,
                "customerID": int(customer_id),
            },
        )

    raise InvalidCredentialsError(username)


@app.get("/load")
async def load(request: Request, username: Optional[str] = None):

    if not await app.db.account_registered(username=username):
        raise AccountDoesNotExistError(username)

    customer_data = await app.db.fetch_one(
        "SELECT * FROM customers WHERE username = ?", username
    )

    if customer_data is None:
        raise AccountDoesNotExistError(username)

    customer_documents = await app.db.fetch_one(
        "SELECT file FROM documents WHERE customer_id = ? LIMIT 1",
        customer_data[0],
    )

    if not customer_documents:
        ## ignore this for now
        # raise DynamicError(
        #     "There are no document IDs associated with that account.", status_code=400
        # )

        return JSONResponse(
            status_code=200,
            content={
                "status": "success",
                "message": "Document loaded successfully.",
                "success": False,
                "document": None,
                "customer_id": int(customer_data[0]),
            },
        )

    else:
        customer_document = customer_documents[0]

    return JSONResponse(
        status_code=200,
        content={
            "status": "success",
            "message": "Document loaded successfully.",
            "success": True,
            "document": b64encode(customer_document).decode("utf-8"),
            "customer_id": int(customer_data[0]),
        },
    )


@app.get("/api/users")
async def users(request: Request, email: Optional[str] = None):
    if email is not None:
        return await app.db.account_registered(email)
    else:
        return None


@app.get("/status")
async def status(request: Request) -> None:
    # check whether the API is running
    return JSONResponse(status_code=200, content={"status": True, "success": True})


@app.post("/renew-pass")
async def renew_password(request: Request):
    data = await request.body()
    data = loads(data)

    username = data.get("email")
    password = data.get("password")
    pass_hash = sha3_256(password.encode()).hexdigest()

    if not await app.db.account_registered(username):
        raise AccountDoesNotExistError(username)

    else:
        await app.db.execute(
            "UPDATE customers SET password = ? WHERE username = ?",
            pass_hash,
            username,
        )
        return JSONResponse(
            status_code=200,
            content={
                "status": "success",
                "message": "Password changed successfully",
                "success": True,
            },
        )


@app.get("/get_authenticator_secret")
async def get_authenticator_secret(request: Request, username: str):
    if not await app.db.account_registered(username):
        raise AccountDoesNotExistError(username=username)

    token = await app.db.get_token(username)

    if token is None:
        raise InvalidCredentialsError(username)

    qr_code = generate_authenticator_setup_qr_code(username, token)

    buffer = BytesIO()
    buffer.seek(0)
    qr_code.save(buffer, format="PNG")

    b64_encoded_qr_code = b64encode(buffer.getvalue()).decode()

    # return the QR code as a base64 encoded string
    return JSONResponse(
        status_code=200,
        content={
            "status": "success",
            "message": "QR code generated successfully",
            "success": True,
            "qr_code": b64_encoded_qr_code,
        },
    )


@app.get("/verify-code")
async def code(
    request: Request, username: Optional[str] = None, code: Optional[int] = None
):
    if username is None or code is None:
        raise MissingRequiredParameterError("username or code")

    access_token = await app.db.get_token(username)

    is_valid: bool = check_code(code, access_token)

    response = JSONResponse(
        status_code=200,
        content={
            "status": "success",
            "message": f"Code is {'not' if not is_valid else ''} valid",
            "success": True,
            "code_valid": is_valid,
        },
    )

    return response


@app.post("/upload")
async def upload(request: Request):
    data = await request.body()
    data = loads(data)

    picture_bytes = data.get("picture").strip()
    extension: str = data.get("extension", "").strip().lower()
    filename: str = data.get("filename", "untitled").strip()
    username = data.get("username")

    if not username:
        raise MissingRequiredParameterError("username")

    elif picture_bytes is None:
        raise MissingRequiredParameterError("picture")

    if not await app.db.account_registered(username):
        raise AccountDoesNotExistError(username)

    customer_id = await app.db.get_customer_id(username)

    picture_bytes = b64decode(picture_bytes)

    await app.db.insert_document(
        int(customer_id),
        filename,
        extension,
        picture_bytes,
    )

    return JSONResponse(
        status_code=200,
        content={
            "status": "success",
            "message": "Picture uploaded successfully",
            "success": True,
        },
    )


@app.get("/make_qr")
async def make_qr(request: Request, data: str):
    qr_code = generate_qr(data)

    # return the QR code as a base64 encoded string
    return JSONResponse(
        status_code=200,
        content={
            "status": "success",
            "message": "QR code generated successfully",
            "success": True,
            "qr_code": qr_code,
        },
    )


if __name__ == "__main__":
    uvicorn.run("main:app", host="127.0.0.1", port=8000, reload=True)
