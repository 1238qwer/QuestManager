using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearGame1 : MonoBehaviour {

    [SerializeField] private Quest clearGame;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        clearGame.QuestConditionClear("b");
    }
}
