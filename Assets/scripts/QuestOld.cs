//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;
//using UnityEngine;


//public class QuestOld : MonoBehaviour ,QuestManager.IQuestListner
//{
 //   [SerializeField] private QuestManager questManager;

 //   private Dictionary<string, bool> isAddQuest = new Dictionary<string, bool>();

 //   // Use this for initialization
 //   void Awake () {
	//	questManager.RegisteListener(this);
 //   }

	//// Update is called once per frame
	//void Update () {


	//}


 //   public void OnQuestRaise(string questID)
 //   {

 //       if (questID == "monster" && !GetIsAdded(questID))
 //       {
 //           isAddQuest.Add(questID, true);
 //       }

 //   }

 //   private bool GetIsAdded(string key)
 //   {
 //       bool isAdd;
 //       isAddQuest.TryGetValue(key, out isAdd);

 //       return isAdd;
 //   }

 //   public void OnQuestClear(string questName)
 //   {
        
 //   }
//}
