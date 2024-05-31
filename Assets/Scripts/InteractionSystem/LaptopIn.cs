using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopIn : MonoBehaviour,IInteractable
{
    [SerializeField] private string _prompt;
    public QInteracion Quest;
    public Quest laptopQuest;
    public string questname;
    public string questdescription;
    
    public void QuestStart()
    {
        Quest.Interact(questname, questdescription);
        Quest.gameObject.SetActive(true);
    }
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
           
            Quest.gameObject.SetActive(false);
        Debug.Log("Interacting");
        return(true);
    }
    public void Start()
    {
        questdescription = laptopQuest.description;
        questname = laptopQuest.questName;
    }
    // Start is called before the first frame update

}
