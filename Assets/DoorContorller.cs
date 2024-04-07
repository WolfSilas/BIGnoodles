using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour, IInteractable
{
    public Vector3 openPositionOffset; // Offset by which the door should move when open
    public float smoothTime = 0.5f; // Smoothness of door opening animation
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    private bool isOpen = false; // Flag to check if the door is open or closed
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private Quaternion startRotation;
    private Quaternion targetRotation;

    void Start()
    {
        // Save the initial position and rotation of the door
        startPosition = transform.position;
        startRotation = transform.rotation;
        // Calculate the target position based on the open position offset
        targetPosition = startPosition;
    }

    void Update()
    {
        // Check if the player presses the "E" key
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleDoor();
        }
    }

    public void ToggleDoor()
    {
        isOpen = !isOpen;
        // Calculate the target position based on whether the door is open or closed
        targetPosition = isOpen ? startPosition + openPositionOffset : startPosition;
        // Calculate the target rotation based on whether the door is open or closed
        targetRotation = isOpen ? Quaternion.Euler(0, 270, 0) * startRotation : startRotation;

        // Start the coroutine to smoothly move and rotate the door
        StartCoroutine(MoveDoor());
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            ToggleDoor();
        }
    }

    IEnumerator MoveDoor()
    {
        float elapsedTime = 0f;
        Vector3 currentPos = transform.position;
        Quaternion currentRot = transform.rotation;

        while (elapsedTime < smoothTime)
        {
            // Move and rotate the door towards the target position and rotation over time
            transform.position = Vector3.Lerp(currentPos, targetPosition, elapsedTime / smoothTime);
            transform.rotation = Quaternion.Slerp(currentRot, targetRotation, elapsedTime / smoothTime);

            // Update the elapsed time
            elapsedTime += Time.deltaTime;
            yield return null; // Wait for the next frame
        }

        // Ensure the door reaches its final position and rotation
        transform.position = targetPosition;
        transform.rotation = targetRotation;
    }

    public bool Interact(Interactor interactor)
    {
        // Open or close the door when interacted with
        ToggleDoor();
        return true; // Interaction successful
    }
}
