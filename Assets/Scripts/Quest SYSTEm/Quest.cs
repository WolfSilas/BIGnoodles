using UnityEngine;

[CreateAssetMenu(fileName = "NewQuest", menuName = "Quest")]
public class Quest : ScriptableObject
{
    public string questName;
    public string description;
    public bool isCompleted;
    public QuestObjective[] objectives;

    public void CompleteQuest()
    {
        isCompleted = true;
        Debug.Log(questName + " is completed!");
    }
}

[System.Serializable]
public class QuestObjective
{
    public string description;
    public bool isCompleted;
}

