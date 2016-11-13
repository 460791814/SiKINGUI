using UnityEngine;
using System.Collections;

public class Knapsack : UIDragDropItem {

    public  UISprite  sprite;
    public UILabel label;
    int count = 1;
    public void AddCount(int num=1)
    { 
        count+=num;
        label.text = count.ToString();
    }
    protected override void OnDragDropRelease(GameObject surface)
    {
            base.OnDragDropRelease(surface);
            print(surface.tag);
            if (surface.tag == "cell")
            {
                //把物品移动到对应的格式下面
                this.transform.parent = surface.transform;
                //居中显示
                this.transform.localPosition = Vector3.zero;

            }
            else if (surface.tag == "food")
            {
                var parent = surface.transform.parent;
                surface.transform.parent = this.transform.parent;
                surface.transform.localPosition = Vector3.zero;
                this.transform.parent = parent;
                //居中显示
                this.transform.localPosition = Vector3.zero;
            }
    }

}
