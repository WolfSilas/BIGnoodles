using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solar : MonoBehaviour, IInteractable
{

    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    // public GameObject SolarPlace;
    // public GameObject Solarbox;
    public GameObject lamp1;
    public GameObject lamp2;
    public GameObject lamp3;
    public GameObject lamp4;
    public Timer timer;
    public ShopManager shopManager;
    public GameObject priceTimer;
    Color color1 = Color.white;
    public GameObject solar;
    
    public bool Interact(Interactor interactor)
    {
        shopManager.AddTokens();
        priceTimer.SetActive(true);
        SetLampColor(lamp1, color1);
        SetLampColor(lamp2, color1);
        SetLampColor(lamp3, color1);
        SetLampColor(lamp4, color1);
        //code so when you interact to make the lights to make the light component  white
        lamp1.SetActive(true);
        lamp2.SetActive(true);
        lamp3.SetActive(true);
        lamp4.SetActive(true);
        timer.enabled = true;
        solar.SetActive(false);
        
        return true;
    }
    private void SetLampColor(GameObject lamp, Color color)
    {
        if (lamp != null)
        {
            Light lt = lamp.GetComponent<Light>();
            if (lt != null)
            {
                lt.color = color;
            }
        }
    }

}