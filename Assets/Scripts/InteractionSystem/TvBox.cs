using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvBox : MonoBehaviour,IInteractable
{
   
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    public GameObject TvPlace;
    public GameObject Tvbox;
    public Timer timer;
    public GameObject priceTimer;
    public GameObject Questcanvas;

    public bool Interact(Interactor interactor)
    {
        priceTimer.SetActive(true);
        Questcanvas.SetActive(false);
        timer.enabled = true;
        Tvbox.SetActive(false);
        TvPlace.SetActive(true);
        return true;
    }
     
}
