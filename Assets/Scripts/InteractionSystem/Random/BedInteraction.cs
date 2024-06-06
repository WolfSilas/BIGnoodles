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
        if (Timeline != null)
        {
            // Play the timeline
            Timeline.Play();

            Timeline.stopped += OnTimelineStopped;
        }
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

    private void OnTimelineStopped(PlayableDirector director)
    {
        // Unsubscribe from the stopped event to avoid memory leaks
        Timeline.stopped -= OnTimelineStopped;

        // Add any actions you want to perform when the timeline ends
        Debug.Log("Timeline ended");
        // You can add additional actions here, such as disabling UI elements, triggering another event, etc.
    }
    // Method to set the visibility of the image
    public PlayableDirector Timeline; // Reference to the PlayableDirector component

    // This method is called when the player interacts with the object
    public void Interact()
    {
        // Check if the timeline is assigned
        
    }
    public void SetImageVisibility(bool isVisible)
    {

        if (sceneLoader != null)
        {
            // Call LoadScene method from SceneLoader
           // sceneLoader.LoadScene();......................................
        }
        else
        {
            Debug.LogError("SceneLoader script is not attached!");
        }
        imageComponent.enabled = isVisible;
        
        // Set the sprite to display if the image is visible
        if (isVisible)
        {
            imageComponent.sprite = spriteToDisplay;
        }
    }
}

