using UnityEngine;
using System.Collections;

public class HitAndAddLife : MonoBehaviour {


    public HUDText text;
	// Use this for initialization
	void Start () {
        //text = GetComponent<HUDText>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            print(1);
            text.Add(-10, Color.red, 0.5f);
         }
        if (Input.GetMouseButtonDown(2))
        {
            print(1);
            text.Add(+10, Color.green, 0.5f);
        }
	}
}
