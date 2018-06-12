using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


public class QuestOld : MonoBehaviour ,QuestManager.IQuestListner
{
    [SerializeField] private QuestManager questManager;
    [SerializeField] private GameObject defultImage;

    private QuestUI questUi;

    private Dictionary<string, bool> isAddQuest = new Dictionary<string, bool>();

    // Use this for initialization
    void Awake () {
		questManager.RegisteListener(this);
        questUi = FindObjectOfType<QuestUI>();
    }

	// Update is called once per frame
	void Update () {


	}


    public void OnQuestRaise(string questID)
    {
        if (questID == "space" && !GetIsAdded(questID)) // 이 부분만 묶어주면된다. // 이부분
        {
            isAddQuest.Add(questID,true);
            questUi.DrawUI(questID,"불타는 스페이스", "스페이스를 10번 누르세요", "보상 : 고급 키보드",defultImage);
        }
        if (questID == "spaceclear" && !GetIsAdded(questID))
        {
            questUi.QuestComplete("space");
        }
        if (questID == "monster" && !GetIsAdded(questID))
        {
            isAddQuest.Add(questID, true);
            questUi.DrawUI(questID, "몬스터 헌터", "고스트를 모두 사살하세요", "보상 : 게임 클리어", defultImage); // 이부분
        }
        if (questID == "monsterClear" && !GetIsAdded(questID))
        {
            questUi.QuestComplete("monster");
        }
        if (questID == "die" && !GetIsAdded(questID))
        {
            isAddQuest.Add(questID, true);
            questUi.DrawUI(questID, "이미 죽은자", "당신은 이미 죽어있습니다", "보상 : 묘비명", defultImage);
        }
        if (questID == "gameclear" && !GetIsAdded(questID))
        {
            isAddQuest.Add(questID, true);
            questUi.DrawUI(questID, "게임클리어", "승리하였습니다!!", "보상 : 성취감", defultImage);
        }
    }

    private bool GetIsAdded(string key)
    {
        bool isAdd;
        isAddQuest.TryGetValue(key, out isAdd);

        return isAdd;
    }
}
