using UnityEngine;

public class TargetObject : MonoBehaviour
{
    public Material originalMaterial;
    public Material changedMaterial;

    private new Renderer renderer;
    private bool isChanged = false;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = originalMaterial; // Set the original material initially
    }

    public void ToggleMaterial()
    {
        if (isChanged)
        {
            renderer.material = originalMaterial;
        }
        else
        {
            renderer.material = changedMaterial;
        }

        isChanged = !isChanged; // Toggle the state
    }
}
