using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class LampSwitch : MonoBehaviour,IInteractable

{
    [SerializeField] private string _prompt;
    public Quest nameQuest;       //
    public string questname;        //
    public string questdescription; //
    public QInteracion QuestInteraction;
    public int LampCounter = 0;
    public ShopManager shopManager;
    public int CompletePrice = 0;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {

        if (LampCounter == 0)
            QuestInteraction.Interact(questname, questdescription);
        LampCounter++;
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
