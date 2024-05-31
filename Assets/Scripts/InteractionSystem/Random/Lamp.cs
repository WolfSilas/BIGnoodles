using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Material hoverMaterial;
    public TargetObject targetObject;
    public float interactionDistance = 3f; // Adjust this distance as needed

    private bool isMouseOver = false;
    private bool isPlayerNear = false;
    private Material originalMaterial;
    private new Renderer renderer;

    private Transform playerTransform;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalMaterial = renderer.material;

        // Find the player's GameObject in the scene and get its transform
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }
        else
        {
            Debug.LogWarning("Player object not found. Make sure the player has the 'Player' tag.");
        }
    }

    void OnMouseEnter()
    {
        isMouseOver = true;
        UpdateCursor();
    }

    void OnMouseExit()
    {
        isMouseOver = false;
        UpdateCursor();
    }

    void Update()
    {
        if (playerTransform != null)
        {
            // Calculate the distance between the player and the lamp
            float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

            // Check if the player is within the interaction distance
            isPlayerNear = distanceToPlayer <= interactionDistance;

            UpdateCursor();
        }
    }

    void UpdateCursor()
    {
        if (isMouseOver && isPlayerNear)
        {
            Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
            renderer.material = hoverMaterial;
        }
        else
        {
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
            renderer.material = originalMaterial;
        }
    }

    void OnMouseDown()
    {
        if (isMouseOver && isPlayerNear)
        {
            Debug.Log("Turned on/off the Lamp!");
            targetObject.ToggleMaterial();
        }
    }
}