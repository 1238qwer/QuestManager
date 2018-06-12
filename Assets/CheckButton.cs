using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckButton : MonoBehaviour {

    [SerializeField] private GameObject checkWindow;

    public void CheckWindow()
    {
        checkWindow.SetActive(false);
    }


}
