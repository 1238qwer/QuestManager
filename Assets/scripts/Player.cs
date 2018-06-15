using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Quest openRoute;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        openRoute.QuestConditionClear("levelup");
    }
}
