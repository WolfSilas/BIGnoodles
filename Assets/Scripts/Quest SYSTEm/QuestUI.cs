using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    public QuestManager questManager;
    public Text questListText;

    void Update()
    {
        DisplayQuests();
    }

    void DisplayQuests()
    {
        questListText.text = "";
        foreach (Quest quest in questManager.quests)
        {
            questListText.text += quest.questName + "\n";
            questListText.text += quest.description + "\n"; // Added line to display description
            foreach (QuestObjective objective in quest.objectives)
            {
                questListText.text += "- " + objective.description + (objective.isCompleted ? " (Completed)" : "") + "\n";
            }
        }
    }
}






