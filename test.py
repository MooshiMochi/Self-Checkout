from modules.database import Database
import os
import asyncio
from modules.ocr import *
import pytesseract
assert os.path.exists("database.db")

# pytesseract.pytesseract.tesseract_cmd = r'Z:\rc639208\Computer Science A level\Year 2 Project\Self-Checkout\tesseract.exe'


db = Database("database.db")


async def list_customers():
    res = await db.fetch_all("SELECT * FROM customers;")
    print(res)

async def main():

    # await list_customers()

    
    customer_documents = (await db.fetch_one(
        "SELECT file FROM documents WHERE customer_id = ? LIMIT 1",
        "1",
    ))[0]

    image = process_image(customer_documents)
    
    # display the image

    # cv2.imshow("Image", image)
    # cv2.waitKey(0)

    text = read_text(image)
    print(text)


asyncio.run(main())
