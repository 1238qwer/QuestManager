using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class Quest : ScriptableObject
{
    public interface IQuestListner
    {
        void OnQuestRaise();
        void OnQuestClear();
    }

    [Serializable]
    public struct Condition
    {
        public string ID;
        public bool clear;
    }

    [SerializeField] public List<IQuestListner> questListner = new List<IQuestListner>();  
    [SerializeField] private Condition[] conditions;

    public string ID;
    public string description;

    private int clearCount;
    private bool raised;

    public void RegistClearLisnter(IQuestListner clearListner)
    {
        Debug.Log("Registed : " + clearListner + " from " + this.ID);
        questListner.Add(clearListner);
    }

    public void UnRegistClearLisnter(IQuestListner clearListner)
    {
        Debug.Log("UnRegisted : " + clearListner + " from " + this.ID);
        questListner.Remove(clearListner);
    }

    public void QuestRaise()
    {
        Debug.Log("Quest Raised!! : " + this.ID);

        raised = true;
        foreach (IQuestListner listner in questListner)
        {
            listner.OnQuestRaise();
        }
    }

    public void QuestConditionClear(string conditionID)
    {
        for (int i = 0; i<conditions.Length; i++)
        {
            if (conditions[i].ID == conditionID&&raised)
            {
                Debug.Log("Quest Condition clear!! : " + this.ID);
                conditions[i].clear = true;

                clearCount++;

                if (clearCount == conditions.Length)
                {
                    Debug.Log("All Quest Condition clear!! : " + this.ID);
                    foreach (IQuestListner listner in questListner)
                    {
                        listner.OnQuestClear();
                        clearCount = 0;
                        raised = false;
                    }
                }
            }
        }
    }

    

}
