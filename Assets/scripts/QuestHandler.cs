using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestHandler : QuestManager.IQuestListner {

    QuestManager questManager;
    public Quest currentQuest;

    bool monsterDeath;

    public QuestHandler (string questName,QuestManager questManager,Monster monster)
    {
        
        monster.AddListner(this); // 지금은 조건부쪽에 자신을 등록하려면 일일히 인자로 받아야된다. 한번에 모든곳에 자신을 등록해야맞음.
        currentQuest = questManager.GetQuest(questName);
        this.questManager = questManager;

        Debug.Log("Occuered Quest : " + currentQuest.ID);
    }

    public void OnQuestClear(string questName)
    {
        Debug.Log("Receive Quest " + questName);
        if (questName == currentQuest.ID)
        {
            monsterDeath = true;
            if (monsterDeath)
            {
                questManager.QuestClear(questName);
            }
        }
    
    }

    public void OnQuestRaise(string questName)
    {
        
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
