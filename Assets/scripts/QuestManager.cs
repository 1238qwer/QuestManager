﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor.MemoryProfiler;

[CreateAssetMenu]
public class QuestManager : ScriptableObject
{
    public Quest[] quests;
    [SerializeField]private List<Quest> activeQuests = new List<Quest>();

    private List<IQuestListner> listners = new List<IQuestListner>();

    public Quest GetQuest(string questName)
    {
        for (int i = 0; i < quests.Length; i++)
        {
            if (quests[i].name == questName)
                return quests[i];
        }

        return null;
    }

    public Quest GetAcitveQuest(string questName)
    {
        for (int i = 0; i < activeQuests.Count; i++)
        {
            if(activeQuests[i].name == questName)
                return activeQuests[i];
        }
        return null;
    }


    public interface IQuestListner
    {
        void OnQuestRaise(string questName);
        void OnQuestClear(string questName);
    }

    public void RegisteListener(IQuestListner listner)
    {
        listners.Add(listner);
    }

    public void UnRegisteListener(IQuestListner listner)
    {
        listners.Remove(listner);
    }



    public void QuestRaise(string questName)
    {
        activeQuests.Add(GetQuest(questName));

        foreach (var listener in listners)
        {
            listener.OnQuestRaise(questName);
        }
    }

    public void QuestClear(string questName)
    {
        activeQuests.Remove(GetQuest(questName));

        foreach (var listener in listners)
        {
            listener.OnQuestClear(questName);
        }
    }
}
