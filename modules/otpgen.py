import time

import pyotp
import qrcode

key = "MOOSHI_GOT_DA_KEY"


def generate_qr_code(username: str, issuer_name: str = "Age Verification App"):
    uri = pyotp.totp.TOTP(key).provisioning_uri(username, issuer_name=issuer_name)
    print(uri)
    img = qrcode.make(uri)
    # img.save("qr.png")
    img.show()
    return img


generate_qr_code("rchiriac16@gmail.com")
