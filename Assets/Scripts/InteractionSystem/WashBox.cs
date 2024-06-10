using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashBox : MonoBehaviour, IInteractable
{

    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
   // public GameObject WashPlace;
   // public GameObject Washbox;
    public Timer timer;
    public GameObject priceTimer;

    public bool Interact(Interactor interactor)
    {
        priceTimer.SetActive(true);

        timer.enabled = true;
    //    Washbox.SetActive(false);
    //  WashPlace.SetActive(true);
        return true;
    }

}