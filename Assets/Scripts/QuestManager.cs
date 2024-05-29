using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public QuestDatabase1 questDatabase;  // Drag the QuestDatabase asset here in the Inspector
    private List<Quest> activeQuests = new List<Quest>();

    void Start()
    {
        // Initialize quests, possibly load from saved data
        foreach (var quest in questDatabase . quests)
        {
            if (!quest.isCompleted)
            {
                activeQuests.Add(quest);
            }
        }
    }

    public void AcceptQuest(Quest quest)
    {
        if (!activeQuests.Contains(quest))
        {
            activeQuests.Add(quest);
            Debug.Log("Quest accepted: " + quest.questName);
        }
    }

    public void CompleteQuest(Quest quest)
    {
        if (activeQuests.Contains(quest))
        {
            quest.isCompleted = true;
            activeQuests.Remove(quest);
            // Reward the player
            Debug.Log("Quest completed: " + quest.questName);
            // Add experience reward, items, etc.
        }
    }

    public List<Quest> GetActiveQuests()
    {
        return activeQuests;
    }
}
