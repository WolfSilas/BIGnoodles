using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;

public class InteractionHint : MonoBehaviour
{

    public GameObject Pickuptext;

    void Start()
    {

        Pickuptext.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        Pickuptext.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Pickuptext.SetActive(false);
    }
    //The object needs to be destroyed 
}