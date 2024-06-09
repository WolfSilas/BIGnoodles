using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;
using UnityEngine.Playables;
using UnityEngine.UI;

public class InteractionHint : MonoBehaviour
{

    public GameObject InteractionUI;

    void Start()
    {
        InteractionUI.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        InteractionUI.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        InteractionUI.SetActive(false);
    }
    //The object needs to be destroyed 
    
}