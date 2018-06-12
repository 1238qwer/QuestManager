using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    [SerializeField] private List<QuestManager.IQuestListner> listners = new List<QuestManager.IQuestListner>();

    public void AddListner(QuestManager.IQuestListner listner)
    {
        listners.Add(listner);
        Debug.Log("Quest Handler Registed : " + listner);
    }

	void Update () {
		if (Input.GetKeyDown(KeyCode.K))
        {
            OnDeath();
        }
	}

    void OnDeath()
    {
        foreach (QuestManager.IQuestListner listener in listners)
        {
            listener.OnQuestClear("monster");

        }
    }
}
