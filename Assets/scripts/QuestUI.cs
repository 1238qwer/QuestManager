using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public struct QuestUIData
{
    public Text questNameText;
    public Text questContentsText;
    public Text questRewardText;
    public GameObject questImage;
    public Button ClearButton;

    public string questClearMessage;
    public string questClearReward;


    public bool isClear;
}

public class QuestUI : MonoBehaviour {

    public QuestManager manager;
    //이놈을 스크립터블 오브젝트로 만들어서 어디서든 접근하게하고싶은데 데이터가 너무많다..

    [SerializeField] private List<QuestUIData> questUis = new List<QuestUIData>();

    [SerializeField] private Dictionary<string,QuestUIData> quests = new Dictionary<string, QuestUIData>();

    [SerializeField] private CompleteWindow completeWindow;

    [SerializeField] private GameObject[] ui;

    [SerializeField] private int max;


    private int index;

    public void DrawUI(string key,string name, string contents, string income,GameObject image)
    {
        if (index < max)
        {
            QuestUIData questUiData = questUis[index];

            ui[index].SetActive(true);

            questUiData.questNameText.text = name;
            questUiData.questContentsText.text = contents;
            questUiData.questRewardText.text = income;

            questUiData.questClearMessage = name + " 클리어!!";
            questUiData.questClearReward = income;

            quests.Add(key,questUiData);

            index++;
        }
    }

    public void QuestComplete(string key)
    {
        QuestUIData data = GetQuest(key);

        data.ClearButton.GetComponent<Button>().interactable = true;
        data.ClearButton.onClick.AddListener(
            delegate
            {
                CompleteButtonClick(key,data);

            }
            );

        data.isClear = true;
    }

    public void CompleteButtonClick(string key,QuestUIData data)
    {
        completeWindow.GetComponent<CompleteWindow>();
        completeWindow.gameObject.SetActive(true);
        completeWindow.Init(data.questClearMessage,data.questClearReward);
    }

    private QuestUIData GetQuest(string key)
    {
        QuestUIData data;

        quests.TryGetValue(key, out data);

        return data;
    }

    //public void OnQuestListen(string questID)
    //{
    //    manager.GetQuest(questID).description
    //}
}



