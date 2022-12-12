import pathlib

import cv2
import numpy as np
from cv2 import Mat

cascade_path = (
    pathlib.Path(cv2.__file__).parent.absolute()
    / "data/haarcascade_frontalface_default.xml"
)

clf = cv2.CascadeClassifier(str(cascade_path))


class CV2Image(Mat):
    """A wrapper for cv2 images use for type hinting"""


def load_image(image_path: str) -> CV2Image:
    """Returns the image at the given path

    __Summary__

    This function uses the cv2.imread function to load an image.
    The function returns the image as a CV2Image.

    __Args__

    image_path: str
        The path to the image

    __Returns__

    CV2Image
        The image at the given path

    __Example__

    >>> load_image("image.jpg")
    <CV2Image>
    """

    return cv2.imread(image_path)


def draw_face_box(image: CV2Image, x: int, y: int, w: int, h: int) -> CV2Image:
    """Draws a rectangle around the face in the image

    __Summary__

    This function uses the cv2.rectangle function to draw a rectangle around the face in the image.
    The function returns the image with the rectangle drawn.

    __Args__

    image: CV2Image
        The image to draw the rectangle on
    x: int
        The x coordinate of the top left corner of the rectangle
    y: int
        The y coordinate of the top left corner of the rectangle
    w: int
        The width of the rectangle
    h: int
        The height of the rectangle

    __Returns__

    CV2Image
        The image with the rectangle drawn

    __Example__

    >>> draw_face(image, x, y, w, h)
    <CV2Image>
    """

    cv2.rectangle(image, (x, y), (x + w, y + h), (0, 255, 0), 2)
    return image


def detect_face(image: CV2Image) -> list[tuple[int, int, int, int]]:
    """Returns a list of faces found in the image

    __Summary__

    This function uses the cv2.CascadeClassifier to detect faces in an image.
    The function returns a list of tuples containing the x, y, width, and height of the faces.
    If no faces are found, the function returns an empty list.

    __Args__

    image: CV2Image
        The image to detect faces in

    __Returns__

    list[tuple[int, int, int, int]]
        A list of tuples containing the x, y, width, and height of the faces

    __Example__

    >>> detect_face("image.jpg")
    [(x, y, w, h), (x, y, w, h), ...]
    """

    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    faces = clf.detectMultiScale(
        gray,
        scaleFactor=1.1,
        minNeighbors=4,
        minSize=(30, 30),
        flags=cv2.CASCADE_SCALE_IMAGE,
    )
    if len(faces) > 0:
        draw_face_box(image, *faces[0])
    else:
        print("No faces found")
    return faces


def is_same_person(image1: str, image2: str, threshold: float = 0.9) -> bool:
    """Returns True if the two images are of the same person

    __Summary__

    This function uses the cv2.matchTemplate function to compare the faces of two images.
    The function returns True if the match is greater than the threshold.
    The threshold is set to 0.9 by default, but can be changed.

    __Args__

    image1: str
        The path to the first image
    image2: str
        The path to the second image
    threshold: float
        The threshold for the match. Defaults to 0.9

    __Returns__

    bool
        True if the match is greater than the threshold, False otherwise

    __Example__

    >>> is_same_person("image1.jpg", "image2.jpg")
    True
    """
    image1, image2 = load_image(image1), load_image(image2)

    faces1 = detect_face(image1)
    faces2 = detect_face(image2)

    if len(faces1) == 1 and len(faces2) == 1:
        x1, y1, w1, h1 = faces1[0]
        x2, y2, w2, h2 = faces2[0]

        img1_face = image1[y1 : y1 + h1, x1 : x1 + w1]
        img2_face = image2[y2 : y2 + h2, x2 : x2 + w2]

        match = cv2.matchTemplate(img1_face, img2_face, cv2.TM_CCOEFF_NORMED)

        loc = np.where(match >= threshold)

        # Check if a valid location was found
        if len(loc[0]) > 0 and len(loc[1]) > 0:
            # A valid location was found, so the images are the same
            return True
        # if np.any(match) > threshold:
        #     return True
    return False
