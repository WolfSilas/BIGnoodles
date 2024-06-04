using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class LaptopIn : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public QInteracion Quest;       //
    public Quest nameQuest;       //
    public string questname;        //
    public string questdescription; //
    public static bool isShopMenuActive = false;
    public GameObject Canvas;
    public ShopMenu menu;
    public void QuestStart()        //
    {
        Quest.Interact(questname, questdescription);
        Quest.gameObject.SetActive(true);
    }
    public string InteractionPrompt => _prompt;
   
    public bool Interact(Interactor interactor)
    {
        
        Canvas.gameObject.SetActive(true);
        Quest.gameObject.SetActive(false);
        Debug.Log("Interacting");
        return (true);
   

    }
    public void Start()
    {
       
        questdescription = nameQuest.description;     //
        questname = nameQuest.questName;              //
    }
    // Start is called before the first frame update
   
}

