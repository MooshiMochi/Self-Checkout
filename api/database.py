from typing import Any

import aiosqlite


class Database:
    def __init__(self, db: str):
        self.db_path = db

    async def async_init(self):
        async with aiosqlite.connect(self.db_path) as db:
            await db.execute(
                "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, username TEXT, password TEXT)"
            )
            await db.commit()

    async def find_one(self, username: str, password_hash: str) -> Any:
        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute(
                "SELECT id FROM users WHERE username=? AND password=?",
                (
                    username,
                    password_hash,
                ),
            )
            result = await cur.fetchone()
            await cur.close()
        return result

    async def check_exists(self, username: str) -> bool:
        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute("SELECT id FROM users WHERE username=?", (username,))
            result = await cur.fetchone()
            await cur.close()
        return result is not None

    async def execute(self, query: str, *params: Any) -> None:
        async with aiosqlite.connect(self.db_path) as db:
            await db.execute(query, (*params,))
            await db.commit()

    async def find_all(self, query: str, *params: Any) -> Any:
        async with aiosqlite.connect(self.db_path) as db:
            cur = await db.execute(query, params)
            result = await cur.fetchall()
            await cur.close()
        return result
