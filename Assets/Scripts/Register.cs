using UnityEngine;
using System.Collections;

public class Register : MonoBehaviour {

    public UIInput userName;
    public UIInput PassWord;

	// Use this for initialization
	void Start () {
	
	}

    public void OnRegisterClick()
    {
        if (userName.value == "admin" && PassWord.value == "admin")
        {
            print("succence");
        }
        else {
            print("faile");
        }
    }
}
