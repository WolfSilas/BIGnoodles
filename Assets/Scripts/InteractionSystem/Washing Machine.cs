using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class WashingMachine : MonoBehaviour,IInteractable
{
    // Start is called before the first frame update
    [SerializeField] private string _prompt;
    public Quest nameQuest;       //
    public string questname;        //
    public string questdescription; //
    public QInteracion QuestInteraction;
    public int WashingCounter = 0;
    public ShopManager shopManager;
    public int CompletePrice = 0;   
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {

        if (WashingCounter == 0)
            QuestInteraction.Interact(questname, questdescription);
        WashingCounter++;
        if (CompletePrice == 0)
        {
            shopManager.AddTokens();
        }
        CompletePrice++;
        return true;
    }
    private void Start()
    {
        questdescription = nameQuest.description;
        questname = nameQuest.questName;
       
    }
}
