using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to change the speed of the character
    private bool isMovementEnabled = true;

    void Update()
    {
        if (!isMovementEnabled)
        {
            return;
        }

        // Get input from the player
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate the movement direction based on input
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the character
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    // Method to disable player movement
    public void DisableMovement()
    {
        isMovementEnabled = false;
    }

    // Method to enable player movement
    public void EnableMovement()
    {
        isMovementEnabled = true;
    }
}
