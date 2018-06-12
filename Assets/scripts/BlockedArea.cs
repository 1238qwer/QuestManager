using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockedArea : MonoBehaviour, QuestManager.IQuestListner
{

    [SerializeField] private QuestManager questManager;
    private List<Transform> sprites = new List<Transform>();

    public void OnQuestClear(string questName)
    {
        if (questName == "monster")
        {
            foreach (var item in sprites)
            {
                item.transform.gameObject.SetActive(true);
            }
            questManager.UnRegisteListener(this);
        }
    }

    public void OnQuestRaise(string questName)
    {

    }

    // Use this for initialization
    void Awake()
    {
        questManager.RegisteListener(this);
        for (int i = 0; i < transform.GetChildCount(); i++)
        {
            sprites.Add(transform.GetChild(i));
        }
    }
}
	

