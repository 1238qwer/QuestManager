using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logger : MonoBehaviour, Quest.IQuestListner
{

    [SerializeField] private Quest clearGame;

    private List<Transform> sprites = new List<Transform>();

    public void OnQuestRaise()
    {
    }

    public void OnQuestClear()
    {
        Debug.Log("축하합니다 다 깨셧어요! DLC를 구매해주세여");
    }

    void Awake()
    {
        clearGame.RegistClearLisnter(this);
    }
}
