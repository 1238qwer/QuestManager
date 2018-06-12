using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyScripts : MonoBehaviour
{

    [SerializeField] private QuestManager questManager;

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
            QuestPost("monster");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            QuestPost("die");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            QuestPost("gameclear");
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            index++;
            if (index > 9)
            {
                QuestPost("spaceclear");
                index = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            index2++;
            if (index2 > 9)
            {
                QuestPost("monsterClear");
                index2 = 0;
            }
        }
    }

    public void QuestPost(string missionName)
    {
        questManager.QuestRaise(missionName);
    }
}
