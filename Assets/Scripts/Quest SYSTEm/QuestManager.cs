using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests;

    public void AddQuest(Quest quest)
    {
        if (!quests.Contains(quest))
        {
            quests.Add(quest);
        }
    }

    public void CompleteObjective(Quest quest, QuestObjective objective)
    {
        if (quests.Contains(quest) && !objective.isCompleted)
        {
            objective.isCompleted = true;
            CheckQuestCompletion(quest);
        }
    }

    private void CheckQuestCompletion(Quest quest)
    {
        foreach (QuestObjective objective in quest.objectives)
        {
            if (!objective.isCompleted)
            {
                return;
            }
        }
        quest.CompleteQuest();
    }
}


