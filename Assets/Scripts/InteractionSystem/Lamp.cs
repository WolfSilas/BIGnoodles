using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;

    private bool isMouseOver = false;

    void OnMouseEnter()
    {
        isMouseOver = true;
        Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
    }

    void OnMouseExit()
    {
        isMouseOver = false;
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    void OnMouseDown()
    {
        if (isMouseOver)
        {
            Debug.Log("Interacted with the item!");
            // Implement interaction logic here
        }
    }
}
