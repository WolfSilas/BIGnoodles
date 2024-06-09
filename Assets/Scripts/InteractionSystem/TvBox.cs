using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvBox : MonoBehaviour,IInteractable
{
   
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    public GameObject TvPlace;
    public GameObject Tvbox;

    public bool Interact(Interactor interactor)
    {
        Tvbox.SetActive(false);
        TvPlace.SetActive(true);
        return true;
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
