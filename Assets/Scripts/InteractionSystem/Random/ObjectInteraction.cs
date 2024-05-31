using UnityEngine;
using System.Collections;

public class DoorOpener : MonoBehaviour, IInteractable
{
    public GameObject door; // Reference to the door object to open
    public Vector3 openPositionOffset; // Offset by which the door should move when open
    public Vector3 openRotationOffset; // Rotation by which the door should rotate when open
    public float openSpeed = 2f; // Speed at which the door opens

    private bool canInteract = false;
    private bool isDoorOpen = false; // Flag to track if the door is open
    private Vector3 initialPosition; // Store initial position of the door
    private Quaternion initialRotation; // Store initial rotation of the door

    public string InteractionPrompt => throw new System.NotImplementedException();

    void Start()
    {
        // Save the initial position and rotation of the door
        initialPosition = door.transform.position;
        initialRotation = door.transform.rotation;
    }

    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            if (isDoorOpen)
            {
                // Close the door
                StartCoroutine(MoveDoorSmoothly(initialPosition, initialRotation));
                isDoorOpen = false;
            }
            else
            {
                // Open the door
                StartCoroutine(MoveDoorSmoothly(initialPosition + openPositionOffset, Quaternion.Euler(initialRotation.eulerAngles + openRotationOffset)));
                isDoorOpen = true;
            }
        }
    }

    IEnumerator MoveDoorSmoothly(Vector3 targetPosition, Quaternion targetRotation)
    {
        float elapsedTime = 0f;
        Vector3 initialPosition = door.transform.position;
        Quaternion initialRotation = door.transform.rotation;

        while (elapsedTime < openSpeed)
        {
            float t = elapsedTime / openSpeed;
            door.transform.position = Vector3.Lerp(initialPosition, targetPosition, t);
            door.transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, t);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the door reaches its final position and rotation
        door.transform.position = targetPosition;
        door.transform.rotation = targetRotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = false;
        }
    }

    public bool Interact(Interactor interactor)
    {
        throw new System.NotImplementedException();
    }
}
