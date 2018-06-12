using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class UIManager : ScriptableObject {

    private QuestUI _questUI = null;


    public QuestUI getQuestUI()
    {
        if (_questUI == null)
        {
            _questUI = new QuestUI();
        }
        return _questUI;
    }

}
