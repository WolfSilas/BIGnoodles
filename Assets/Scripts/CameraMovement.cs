using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Adjust this value to control mouse sensitivity
    private float verticalRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Calculate vertical rotation
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // Clamp vertical rotation to prevent flipping

        // Rotate the camera around its local X axis (up/down movement)
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // Rotate the player (left/right movement)
        transform.parent.Rotate(Vector3.up * mouseX);
    }
}
