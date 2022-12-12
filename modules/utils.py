from base64 import b64encode
from io import BytesIO

import qrcode


def generate_qr(data: str | int) -> str:
    """
    __Summary__

    Generate a QR code from the given data.

    __Arguments__

    * data (str | int): The data to encode in the QR code

    __Returns__

    * str: The base64 encoded QR code
    """
    qr = qrcode.QRCode(
        version=1,
        error_correction=qrcode.constants.ERROR_CORRECT_L,
        box_size=10,
        border=4,
    )
    qr.add_data(data)
    qr.make(fit=True)
    img = qr.make_image(fill_color="black", back_color="white")

    buffer = BytesIO()
    buffer.seek(0)
    img.save(buffer, format="PNG")
    return b64encode(buffer.getvalue()).decode("utf-8")
