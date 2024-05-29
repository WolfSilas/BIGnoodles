using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestDatabase", menuName = "Quests/QuestDatabase")]
public class QuestDatabase : ScriptableObject
{
    public Quest[] quests;
}

