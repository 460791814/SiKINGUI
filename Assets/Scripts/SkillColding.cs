using UnityEngine;
using System.Collections;

public class SkillColding : MonoBehaviour {

    public UISprite uiSprite;

    public float coldTime = 2;//技能冷却时间
    public bool isColding = false;//是否正在冷却
    void Awake()
    {
        uiSprite = transform.Find("Sprite").GetComponent<UISprite>();
    }
    void Update()
    {
        //按下A键并且技能不在冷却状态
        if (Input.GetKeyDown(KeyCode.A) && isColding == false)
        {
            isColding = true;
            //开启技能遮罩
            uiSprite.fillAmount = 1;
        }
        if (isColding)
        {
            //Time.deltaTime 假如一秒内执行update 100次  则Time.deltaTime=1/100 
            uiSprite.fillAmount -= 1f / coldTime * Time.deltaTime;
            if (uiSprite.fillAmount < 0.05f)
            {
                isColding = false;
                //开启技能遮罩
                uiSprite.fillAmount = 0;
            }
        }
    }
}
