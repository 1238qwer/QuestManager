using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestButton: MonoBehaviour {

    [SerializeField] private GameObject questWindow;

    public void QuestSetting()
    {
        questWindow.SetActive(!questWindow.activeSelf);
    }

}
