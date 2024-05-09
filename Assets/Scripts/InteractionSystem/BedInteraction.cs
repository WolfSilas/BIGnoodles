using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class BedInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    // Reference to the UI Image component
    public Image imageComponent;

    // Reference to the sprite you want to display
    public Sprite spriteToDisplay;

    private PlayerController playerController;

    private bool isImageVisible = false;

    public SceneLoader sceneLoader;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>(); // Find the PlayerController object in the scene
    }

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Going to Sleep!");

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
    public PlayableDirector transitionTimeline;
    public void SetImageVisibility(bool isVisible)
    {
        if (sceneLoader != null)
        {
            // Call LoadScene method from SceneLoader
            sceneLoader.LoadScene();
        }
        else
        {
            Debug.LogError("SceneLoader script is not attached!");
        }
        imageComponent.enabled = isVisible;
        if (transitionTimeline != null)
        {
            transitionTimeline.Play();
        }
        // Set the sprite to display if the image is visible
        if (isVisible)
        {
            imageComponent.sprite = spriteToDisplay;
        }
    }
}

