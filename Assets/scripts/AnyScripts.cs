using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyScripts : MonoBehaviour
{

    [SerializeField] private QuestManager questManager;
    [SerializeField] private Monster monster;

    int index;
    int index2;

    // Use this for initialization
    void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Q))
	    {
	        QuestPost("space");
	    }
	    if (Input.GetKeyDown(KeyCode.W))
        {
            QuestHandler questHandler = new QuestHandler("monster", questManager, monster);
            QuestPost("monster");
        }


    }

    public void QuestPost(string missionName)
    {
        questManager.QuestRaise(missionName);
    }
}
