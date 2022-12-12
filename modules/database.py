from typing import Any

import aiosqlite

from models.errors import AccountExistsError
from modules.tokens import generate_token


class Database:
    def __init__(self, db: str):
        self.db_path = db

    async def async_init(self):
        async with aiosqlite.connect(self.db_path) as db:
            await db.execute(
                """
                CREATE TABLE IF NOT EXISTS customers (
                    customer_id INTEGER PRIMARY KEY,
                    username TEXT,
                    password TEXT,
                    access_token TEXT
                )
                """
            )
            await db.execute(
                """
                CREATE TABLE IF NOT EXISTS documents (
                    customer_id INTEGER,
                    filename TEXT,
                    extension TEXT,
                    file TEXT,
                    FOREIGN KEY (customer_id) REFERENCES customers (customer_id),
                    UNIQUE (customer_id)
                    )
                """
            )

            await db.execute(
                """
                CREATE TABLE IF NOT EXISTS personal_details (
                    customer_id INTEGER PRIMARY KEY,
                    first_name TEXT,
                    last_name TEXT,
                    email TEXT,
                    FOREIGN KEY (customer_id) REFERENCES customers (customer_id)
                )
                """
            )

            await db.execute(
                """
                CREATE TABLE IF NOT EXISTS addresses (
                    customer_id INTEGER PRIMARY KEY,
                    address_line_1 TEXT,
                    address_line_2 TEXT,
                    city TEXT,
                    state TEXT,
                    zip_code TEXT,
                    FOREIGN KEY (customer_id) REFERENCES customers (customer_id)
                )
                """
            )
            await db.commit()

    async def execute(self, query: str, *params: Any) -> None:
        """
        __Summary__

        Execute a query

        __Arguments__

        * query (str): The SQL query to execute
        * params (Any): The parameters to pass to the query

        __Returns__

        * None
        """
        async with aiosqlite.connect(self.db_path) as db:
            await db.execute(query, (*params,))
            await db.commit()

    async def fetch_one(self, query: str, *params: list[Any] | tuple[Any]) -> Any:
        """
        __Summary__

        Fetch one row from the database

        __Arguments__

        * query (str): The SQL query to execute
        * params (Any): The parameters to pass to the query

        __Returns__

        * Any: A row
        """
        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute(query, params)
            result = await cur.fetchone()
            await cur.close()
        return result

    async def fetch_all(self, query: str, *params: Any) -> list[Any]:
        """
        __Summary__

        Fetch all rows from the database

        __Arguments__

        * query (str): The SQL query to execute
        * params (Any): The parameters to pass to the query

        __Returns__

        * list[Any]: A list of rows
        """
        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute(query, params)
            result = await cur.fetchall()
            await cur.close()
        return result

    async def get_customer_id(self, username: str) -> Any:
        """
        __Summary__

        Get the customer ID of a user

        __Arguments__

        * username (str): The username of the user

        __Returns__

        * Any: The customer ID of the user
        """

        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute(
                "SELECT customer_id FROM customers WHERE username=? LIMIT 1",
                (username,),
            )
            result = await cur.fetchone()
            print(result)
            await cur.close()
        print(result)
        return result[0] if result is not None else None

    async def account_registered(self, username: str) -> bool:
        """
        __Summary__

        Check if an account is registered using their username

        __Arguments__

        * username (str): The username of the user

        __Returns__

        * bool: True if the account is registered, False otherwise

        """
        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute(
                "SELECT customer_id FROM customers WHERE username=?", (username,)
            )
            result = await cur.fetchone()
            await cur.close()
        return result is not None

    async def token_exists(self, access_token: str) -> bool:
        """
        __Summary__

        Check if an access token exists

        __Arguments__

        * access_token (str): The access token to check

        __Returns__

        * bool: True if the access token exists, False otherwise
        """
        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute(
                "SELECT customer_id FROM customers WHERE access_token=?",
                access_token,
            )
            result = await cur.fetchone()
            await cur.close()
        return result is not None

    async def customer_registered(self, customer_id: int) -> bool:
        """
        __Summary__

        Check if a customer is registered using their customer ID

        __Arguments__

        * customer_id (int): The customer ID of the customer

        __Returns__

        * bool: True if the customer is registered, False otherwise
        """
        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute(
                "SELECT customer_id FROM customers WHERE customer_id=?", (customer_id,)
            )
            result = await cur.fetchone()
            await cur.close()
        return result is not None

    async def credentials_match(self, username: str, password_hash: str) -> bool:
        """
        __Summary__

        Check if the username and password provided match those stored in the database

        __Arguments__

        * username (str): The username of the user
        * password_hash (str): The hashed password of the user

        __Returns__

        * bool: True if the credentials match, False otherwise
        """

        result: dict[str] = await self.fetch_one(
            "SELECT username, password FROM customers WHERE username=? AND password=?",
            username,
            password_hash,
        )
        assert result is not None, "Invalid username or password"

        return result[0] == username and result[1] == password_hash

    async def insert_document(
        self, customer_id: int, filename: str, extension: str, file: bytes
    ) -> None:
        """
        __Summary__

        Insert a document into the database

        __Arguments__

        * customer_id (int): The customer ID of the customer
        * filename (str): The filename of the document
        * extension (str): The extension of the document
        * file (bytes): The file contents of the document

        __Returns__

        * None
        """
        async with aiosqlite.connect(self.db_path) as db:
            await db.execute(
                "INSERT INTO documents (customer_id, filename, extension, file) VALUES ($1, $2, $3, $4) ON CONFLICT(customer_id) DO UPDATE SET filename = $2, extension = $3, file = $4",
                (customer_id, filename, extension, file),
            )
            await db.commit()

    async def register_customer(self, username: str, password_hash: str) -> None:
        """
        __Summary__

        Register a customer

        __Arguments__

        * username (str): The username of the customer
        * password_hash (str): The hashed password of the customer

        __Returns__

        * None
        """

        if await self.account_registered(username):
            raise AccountExistsError(username)

        await self.execute(
            "INSERT INTO customers (username, password, access_token) VALUES (?, ?, ?) ON CONFLICT DO NOTHING",
            username,
            password_hash,
            generate_token(username, password_hash),
        )

    async def get_token(self, username: str) -> str:
        """
        __Summary__

        Get the access token for a user

        __Arguments__

        * username (str): The username of the user

        __Returns__

        * str: The access token for the user
        """

        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute(
                "SELECT access_token FROM customers WHERE username=?",
                (username,),
            )
            result = await cur.fetchone()
            await cur.close()

        return result[0] if result is not None else None
