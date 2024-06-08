using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QInteracion : MonoBehaviour
{
    public string InteractionPrompt => "Press 'E' to interact";
    public TMP_Text QuestText;          //
    public TMP_Text QuestDescription;   //

    public bool Interact(string questname,string description)
    {
        QuestDescription.text = description;    //
        QuestText.text = questname;             //
        Debug.Log("Interaction triggered!");    //

        if (this != null)

        {
            this.gameObject.SetActive(true);
            Debug.Log("Interaction triggered!");
            
            return true;
        }
        return false;
    }

}




