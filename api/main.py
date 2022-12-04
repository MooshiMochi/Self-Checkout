from hashlib import sha3_256
from json import dumps, loads
from typing import Optional

import uvicorn
from database import Database
from fastapi import FastAPI
from fastapi.middleware.cors import CORSMiddleware
from fastapi.requests import Request


class API(FastAPI):
    def __init__(self, *args, **kwargs) -> None:
        super().__init__(*args, **kwargs)
        self.db: Database = Database("database.db")


app = API()

app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)


@app.on_event("startup")
async def startup():
    await app.db.async_init()


@app.post("/login")
async def login(request: Request):
    print("Received login request")
    data = await request.body()
    data = loads(data)

    hashed_password = sha3_256(data["password"].encode()).hexdigest()
    print(hashed_password)

    await app.db.execute(
        "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, username TEXT, password TEXT)"
    )

    result = await app.db.find_one(
        data["username"],
        password_hash=hashed_password,
    )

    if result is None:
        return {
            "status": "error",
            "message": "Invalid username or password",
            "success": False,
        }
    else:
        return {
            "status": "success",
            "message": "Logged in successfully",
            "success": True,
        }


@app.post("/register")
async def register(request: Request):
    data = await request.body()
    data = loads(data)

    username = data["email"]
    password = data["password"]
    pass_hash = sha3_256(password.encode()).hexdigest()

    if not await app.db.check_exists(username):

        await app.db.execute(
            "INSERT INTO users (username, password) VALUES (?, ?) ON CONFLICT DO NOTHING",
            username,
            pass_hash,
        )
        return {
            "status": "success",
            "message": "Registered successfully",
            "success": True,
        }

    else:
        return {
            "status": "error",
            "message": "Username already exists",
            "success": False,
        }


@app.get("/load")
async def load(request: Request):
    return True


@app.post("/upload")
async def upload(request: Request):
    return True


@app.get("/api/users")
async def users(request: Request, email: Optional[str] = None):
    if email is not None:
        return await app.db.check_exists(email)
    else:
        return None


if __name__ == "__main__":
    uvicorn.run("main:app", host="127.0.0.1", port=8000, reload=True)
