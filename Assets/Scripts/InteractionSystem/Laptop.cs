using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter: MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    // Reference to the UI Image component
    public Image imageComponent;

    // Reference to the sprite you want to display
    public Sprite spriteToDisplay;

    private PlayerController playerController;

    private bool isImageVisible = false;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>(); // Find the PlayerController object in the scene
    }

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Letter opened!");

        // Toggle the visibility of the Image component
        isImageVisible = !isImageVisible;
        SetImageVisibility(isImageVisible);

        // Control player movement
        if (isImageVisible)
        {
            playerController.DisableMovement();
        }
        else
        {
            playerController.EnableMovement();
        }

        return true;
    }

    // Method to set the visibility of the image
    public void SetImageVisibility(bool isVisible)
    {
        imageComponent.enabled = isVisible;

        // Set the sprite to display if the image is visible
        if (isVisible)
        {
            imageComponent.sprite = spriteToDisplay;
        }
    }
}
