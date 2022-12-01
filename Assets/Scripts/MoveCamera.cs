using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float mouseSensitivity = 500f;
    public Transform playerBody;


    private float xRotationCamera = 0f;
    private float xRotationWeapon = 90f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotationCamera -= mouseY;
        xRotationCamera = Mathf.Clamp(xRotationCamera, -90f, 90f);

        xRotationWeapon -= mouseY;
        xRotationWeapon = Mathf.Clamp(xRotationWeapon, 0f, 180f);

        transform.localRotation = Quaternion.Euler(xRotationCamera, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
