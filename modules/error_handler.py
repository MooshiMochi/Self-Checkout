from fastapi.requests import Request
from fastapi.responses import JSONResponse

from models.errors import *
from models.states import EMPTY


async def on_error(request: Request, exc: Exception):

    print("Error Occurred:", exc)

    response_content = {
        "status": "error",
        "success": False,
    }
    status_code = 500

    if isinstance(exc, AccountExistsError):
        status_code = 400

        if exc.customer_id is not EMPTY:
            response_content[
                "message"
            ] = f"Account with the ID '{exc.customer_id}' already exists."
        else:
            response_content["message"] = f"Account '{exc.username}' already exists."

    elif isinstance(exc, AccountDoesNotExistError):
        status_code = 400

        if exc.customer_id is not EMPTY:
            response_content[
                "message"
            ] = f"Account with the ID '{exc.customer_id}' does not exist."
        else:
            response_content["message"] = f"Account '{exc.username}' does not exist."

    elif isinstance(exc, MissingRequiredParameterError):
        status_code = 400
        response_content[
            "message"
        ] = f"The required parameter '{exc.parameter}' is missing."

    elif isinstance(exc, DynamicError):
        status_code = exc.status_code
        response_content["message"] = exc.message

    elif isinstance(exc, InvalidCredentialsError):
        status_code = 400
        response_content[
            "message"
        ] = f"Invalid credentials for account '{exc.username}'."

    else:
        response_content["message"] = str(exc)

    return JSONResponse(
        status_code=status_code,
        content=response_content,
    )
