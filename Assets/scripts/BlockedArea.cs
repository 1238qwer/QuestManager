using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockedArea : MonoBehaviour, Quest.IQuestListner
{
    [SerializeField] private Quest onRoute;

    private List<Transform> sprites = new List<Transform>();


    public void OnQuestRaise()
    {
        
    }

    public void OnQuestClear()
    {
        foreach (var item in sprites)
        {
            item.transform.gameObject.SetActive(true);
        }
    }


    void Awake()
    {
        onRoute.RegistClearLisnter(this);
        for (int i = 0; i < transform.GetChildCount(); i++)
        {
            sprites.Add(transform.GetChild(i));
        }
    }
}
	

