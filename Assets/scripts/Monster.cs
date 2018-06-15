using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    [SerializeField] private Quest openRoute;

    void Update () {
		if (Input.GetKeyDown(KeyCode.K))
        {
            OnDeath();
        }
	}

    void OnDeath()
    {
        openRoute.QuestConditionClear("bosskill");
    }

}
