using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyScripts : MonoBehaviour
{

    [SerializeField] private Quest onRoute;
    [SerializeField] private Quest clearGame;



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
            onRoute.QuestRaise();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            clearGame.QuestRaise();
        }


    }
}
