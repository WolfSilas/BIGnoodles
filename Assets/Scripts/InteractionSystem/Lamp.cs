using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Material hoverMaterial;
    public TargetObject targetObject;

    private bool isMouseOver = false;
    private Material originalMaterial;
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalMaterial = renderer.material;
    }

    void OnMouseEnter()
    {
        isMouseOver = true;
        Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
        renderer.material = hoverMaterial;
    }

    void OnMouseExit()
    {
        isMouseOver = false;
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
        renderer.material = originalMaterial;
    }

    void OnMouseDown()
    {
        if (isMouseOver)
        {
            Debug.Log("Interacted with the item!");
            targetObject.ToggleMaterial();
        }
    }
}

//dick
//several dicks suck