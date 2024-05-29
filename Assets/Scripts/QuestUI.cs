using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestUI : MonoBehaviour
{
    public QuestManager questManager;
    public GameObject questPanelPrefab;
    public Transform questPanelParent;

    void Start()
    {
        UpdateQuestUI();
    }

    public void UpdateQuestUI()
    {
        foreach (Transform child in questPanelParent)
        {
            Destroy(child.gameObject);
        }

        List<Quest> activeQuests = questManager.GetActiveQuests();

        foreach (var quest in activeQuests)
        {
            GameObject questPanel = Instantiate(questPanelPrefab, questPanelParent);
            questPanel.transform.Find("QuestName").GetComponent<Text>().text = quest.questName;
            questPanel.transform.Find("QuestDescription").GetComponent<Text>().text = quest.description;
            questPanel.transform.Find("CompleteButton").GetComponent<Button>().onClick.AddListener(() => CompleteQuest(quest));
        }
    }

    public void CompleteQuest(Quest quest)
    {
        questManager.CompleteQuest(quest);
        UpdateQuestUI();
    }
}

