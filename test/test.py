import cv2

from modules.faceDetect import detect_face, draw_face_box, is_same_person, load_image

if __name__ == "__main__":

    im1_path = "samples\sample_id_1.jfif"
    im2_path = "samples\sample_id_2.jfif"

    img1 = load_image(im1_path)
    img2 = load_image(im2_path)

    faces1 = detect_face(img1)
    faces2 = detect_face(img2)

    draw_face_box(img1, *faces1[0])
    draw_face_box(img2, *faces2[0])

    # cv2.imshow("Image 1", img1)
    # cv2.imshow("Image 2", img2)

    print(is_same_person(im1_path, im2_path))

    if cv2.waitKey(0) & 0xFF == ord("q"):
        cv2.destroyAllWindows()
