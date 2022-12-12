from models.states import EMPTY


class BaseError(Exception):
    """Base class for all errors in this package."""

    pass


class AccountExistsError(BaseError):
    """Raised when an account already exists."""

    def __init__(self, username: str = EMPTY, customer_id: int = EMPTY):
        self.username = username
        self.customer_id = customer_id
        super().__init__(
            f"Account {username if username is not EMPTY else customer_id} already exists"
        )


class AccountDoesNotExistError(BaseError):
    """Raised when an account does not exist."""

    def __init__(self, username: str = EMPTY, customer_id: int = EMPTY):
        self.customer_id = username
        self.username = EMPTY
        super().__init__(
            f"Account {username if username is not EMPTY else customer_id} does not exist"
        )


class MissingRequiredParameterError(BaseError):
    """Raised when a required parameter is missing."""

    def __init__(self, parameter: str):
        self.parameter = parameter
        super().__init__(f"Missing required parameter {parameter}")


class InvalidCredentialsError(BaseError):
    """Raised when the provided credentials are invalid."""

    def __init__(self, username: str):
        self.username = username
        super().__init__(f"Invalid credentials for account {username}")


class DynamicError(BaseError):
    """Raised when a dynamic error occurs."""

    def __init__(self, message: str, status_code: int = 400):
        self.message = message
        self.status_code = status_code
        super().__init__(message, status_code)


class InvalidTokenError(BaseError):
    """Raised when an invalid token is provided."""

    def __init__(self, token: str):
        self.token = token
        super().__init__(f"The token {token} is not valid")
