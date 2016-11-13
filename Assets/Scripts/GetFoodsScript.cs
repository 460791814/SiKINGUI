using UnityEngine;
using System.Collections;

public class GetFoodsScript : MonoBehaviour {

    public GameObject[] gezi;
    public string[] foodsName;
    public GameObject item;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PickUp();
        }
	}

    void PickUp()
    {
        string foodName=foodsName[Random.Range(0,foodsName.Length)];
        item.GetComponent<UISprite>().spriteName = foodName;
        for (int i = 0; i < gezi.Length; i++)
        {
            if (gezi[i].transform.childCount >  0)
            {
               
                if (gezi[i].GetComponentInChildren<Knapsack>().sprite.spriteName == foodName)
                {
                    gezi[i].GetComponentInChildren<Knapsack>().AddCount(1);
                    return;
                }
            }
        }
        for (int i = 0; i < gezi.Length; i++)
        {
            if (gezi[i].transform.childCount <= 0)
            {
               
                //  如果该格子没有物品
                NGUITools.AddChild(gezi[i],item);
                return;
            }
        }
    }
}
