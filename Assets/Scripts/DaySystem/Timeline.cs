using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class InteractionObject : MonoBehaviour
{
    public PlayableDirector timeline; // Reference to the PlayableDirector component

    // This method is called when the player interacts with the object
    public void Interact()
    {
        // Check if the timeline is assigned
        if (timeline != null)
        {
            // Play the timeline
            timeline.Play();
        }
    }
}

