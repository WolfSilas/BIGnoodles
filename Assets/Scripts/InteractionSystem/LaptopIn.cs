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
    public GameObject Canvas; //ShopUI
    public ShopManager shopManager;
    public int CompletePrice = 0;
    public void QuestStart()        //
    {
        Quest.Interact(questname, questdescription);
        Quest.gameObject.SetActive(true);
    }
    public string InteractionPrompt => _prompt;
   
    public bool Interact(Interactor interactor)
    {
        if (CompletePrice == 0)
        {
         //   shopManager.AddTokens();
        }
        CompletePrice++;



        Canvas.gameObject.SetActive(true);
        Quest.gameObject.SetActive(false);
        Debug.Log("Interacting");
        if (!Canvas.activeSelf)
        {
            Cursor.lockState = CursorLockMode.Locked;   
            Cursor.visible = false;

        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        return (true);
   

    }
   // public void Start()
   /// {
       
   //    questdescription = nameQuest.description;     //
    //    questname = nameQuest.questName;              //
  //  }
   
}

