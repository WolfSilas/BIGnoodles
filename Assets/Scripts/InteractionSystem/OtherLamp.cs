using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class OtherLamp : MonoBehaviour,IInteractable
{
    // Start is called before the first frame update
    [SerializeField] private string _prompt;
    public Quest nameQuest;       //
    public string questname;        //
    public string questdescription; //
    public QInteracion QuestInteraction;
    public int LampCounter = 0;
    public ShopManager shopManager;
    public int CompletePrice = 0;
    public GameObject light;

    public GameObject priceTimer;
    public Timer timer;


    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        light.SetActive(false);
        timer.enabled = true;
        if (LampCounter == 0)
            QuestInteraction.Interact(questname, questdescription);
        LampCounter++;
        if (CompletePrice == 0)
        {
            priceTimer.SetActive(true);
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
