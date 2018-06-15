using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearGame : MonoBehaviour
{
    [SerializeField] private Quest clearGame;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        clearGame.QuestConditionClear("a");
    }
}
