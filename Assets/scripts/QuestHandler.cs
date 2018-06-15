//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class QuestHandler : QuestManager.IQuestListner
//{

//    QuestManager questManager;
//    public Quest currentQuest;

//    private List<string> clearCondition = new List<string>();

//    int clearCount;

//    public QuestHandler(string questName, QuestManager questManager, List<QuestManager.IQuestPoster> posters)
//    {
//        foreach (var poster in posters)
//        {
//            poster.AddListner(this);
//        }

//        currentQuest = questManager.GetQuest(questName);

//        this.questManager = questManager;
//        this.clearCondition = currentQuest.clearCondition;

//        clearCount = clearCondition.Count;

//        Debug.Log("Occuered Quest : " + currentQuest.ID);
//    }

//    public void OnQuestClear(string clearName)
//    {

//        if (clearCondition.Contains(clearName))
//        {
//            Debug.Log("Clear Condition " + clearName);

//            clearCount--;
//            Debug.Log(clearCount);
//            if (clearCount == 0)
//                questManager.QuestClear(currentQuest.ID);
//        }

//    }

//    public void OnQuestRaise(string questName)
//    {

//    }


//    Use this for initialization

//   void Start () {


//    }

//    Update is called once per frame

//    void Update()
//    {

//    }
//}
