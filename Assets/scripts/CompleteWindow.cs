using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompleteWindow : MonoBehaviour
{

    [SerializeField] private Text messageText;
    [SerializeField] private Text rewardText;

    public void Init(string message, string reward)
    {
  
        messageText.text = message;
        rewardText.text = reward;
    }
}
