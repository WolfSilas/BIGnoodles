using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopIn : MonoBehaviour,IInteractable
{
    [SerializeField] private string _prompt;
    public QInteracion Quest;       //
    public Quest nameQuest;       //
    public string questname;        //
    public string questdescription; //
    public static bool isShopMenuActive = false;
    public GameObject shopCanvas;

    public void QuestStart()        //
    {
        Quest.Interact(questname, questdescription);
        Quest.gameObject.SetActive(true);
    }
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        isShopMenuActive = true;
        ToggleShopCanvas();
        Quest.gameObject.SetActive(false);
        Debug.Log("Interacting");
        return(true);
    }
    public void Start()
    {
        questdescription = nameQuest.description;     //
        questname = nameQuest.questName;              //
    }
    // Start is called before the first frame update
    void ToggleShopCanvas()
    {
        shopCanvas.SetActive(!shopCanvas.activeSelf);
        isShopMenuActive = shopCanvas.activeSelf; // Update the static flag

        if (!shopCanvas.activeSelf )
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
