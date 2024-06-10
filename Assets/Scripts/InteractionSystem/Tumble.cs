using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumble : MonoBehaviour, IInteractable
{

    [SerializeField] private string _prompt;
    public ShopManager ShopManager;
    public string InteractionPrompt => _prompt;
    // public GameObject TumblePlace;
    // public GameObject Tumblebox;
    public Timer timer;
    public GameObject priceTimer;
    public GameObject tumble;

    public bool Interact(Interactor interactor)
    {
        priceTimer.SetActive(true);
        ShopManager.AddTokens();
        timer.enabled = true;
        tumble.SetActive(false);
        //    Washbox.SetActive(false);
        //  WashPlace.SetActive(true);
        return true;
    }

}