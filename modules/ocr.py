import cv2
import numpy as np
import pytesseract

from modules.faceDetect import load_image


def process_image(image_path_or_bytes) -> np.ndarray:
    """
    __Summary__

    Preprocess the image to improve the accuracy of the OCR

    __Arguments__

    * image_path (str): The path to the image to preprocess

    __Returns__

    * np.ndarray: The preprocessed image
    """

    # load the image
    if isinstance(image_path_or_bytes, bytes):
        img = load_image(image_bytes=image_path_or_bytes)
    else:
        img = load_image(image_path_or_bytes)

    # convert the image to grayscale
    gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

    # apply image thresholding to enhance the contrast of the text
    threshold_result = cv2.adaptiveThreshold(
        gray, 255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C, cv2.THRESH_BINARY_INV, 11, 2
    )

    try:
        _, img_threshold = threshold_result
    except ValueError:
        img_threshold = threshold_result

    # apply image sharpening to improve the clarity of the text
    kernel = np.array([[-1, -1, -1], [-1, 9, -1], [-1, -1, -1]])

    # apply noise removal to eliminate any unwanted elements from the image
    sharp = cv2.filter2D(img_threshold, -1, kernel)

    # save the preprocessed image
    denosied = cv2.fastNlMeansDenoising(sharp, None, 10, 7, 21)

    # save the preprocessed image
    cv2.imwrite("picture_preprocessed.jpg", denosied)
    return denosied


def read_text(image_path_or_bytes) -> list[str]:
    """
    __Summary__

    Read the text from the preprocessed image

    __Arguments__

    * image_path (str): The path to the preprocessed image

    __Returns__

    * list[str]: The text from the image
    """
    # use Tesseract to process the preprocessed image and extract the text
    text = pytesseract.image_to_string(image_path_or_bytes)
    return text
