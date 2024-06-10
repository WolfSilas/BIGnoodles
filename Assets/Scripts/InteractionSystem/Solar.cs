using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solar : MonoBehaviour, IInteractable
{

    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    // public GameObject SolarPlace;
    // public GameObject Solarbox;
    public Timer timer;
    public GameObject priceTimer;

    public bool Interact(Interactor interactor)
    {
        priceTimer.SetActive(true);

        timer.enabled = true;
        //    Solarbox.SetActive(false);
        //  SolarPlace.SetActive(true);
        return true;
    }

}