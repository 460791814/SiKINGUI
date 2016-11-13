using UnityEngine;
using System.Collections;

public class Chat : MonoBehaviour {

    public UIInput input;
    public UITextList textList;

    void Awake()
    {
        input = GetComponent<UIInput>();
    }

    public void OnSendMsg()
    {
        textList.Add(input.value);
        input.value = "";
    }
}
