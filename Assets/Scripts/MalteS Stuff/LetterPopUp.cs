using UnityEngine;

public class LetterPopUp : MonoBehaviour
{
    public GameObject letterImage; // Assign the image GameObject in the Unity Editor
    public GameObject player; // Assign the player GameObject in the Unity Editor
    public float interactDistance = 5.0f; // Set the maximum interaction distance in the Unity Editor

    public static bool isLetterImageActive = false; // Static flag to indicate if the letter image is active

    private void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape) && isLetterImageActive)
        {
            // Disable the letter image
            letterImage.SetActive(false);
            isLetterImageActive = false;
        }
    }

    private void OnMouseDown()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Check the distance between the player and this object
            float distance = Vector3.Distance(player.transform.position, transform.position);

            if (distance <= interactDistance)
            {
                // Toggle the active state of the letter image
                letterImage.SetActive(!letterImage.activeSelf);
                isLetterImageActive = letterImage.activeSelf; // Update the flag
            }
        }
    }
}
