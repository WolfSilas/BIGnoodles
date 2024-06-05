using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;

public class InteractionHint : MonoBehaviour
{

    public GameObject Pickuptext;
    public GameObject InteractionUI;

    void Start()
    {
        InteractionUI.SetActive(false);
        Pickuptext.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        InteractionUI.SetActive(true);
        Pickuptext.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        InteractionUI.SetActive(false);
        Pickuptext.SetActive(false);
    }
    //The object needs to be destroyed 
}