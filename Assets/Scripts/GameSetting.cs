using UnityEngine;
using System.Collections;

public class GameSetting : MonoBehaviour {
    public  float volume = 1; //音量
    public  GameGrade grade = GameGrade.NORMAL;
    public  ControlType controlType = ControlType.KEYBOARD;
    public  bool IsFullScreen = false;//是否全屏

    public TweenPosition startOption;//开始设置动画
    public TweenPosition completeOption;//完成设置动画

    public void OnVolumChanged()
    {
    
       // UIProgressBar.current.value  获取当前操作的滑动条的值，一个页面可以有多个滑动条
        volume = UIProgressBar.current.value;
    }

    public void OnGameGradeChanged() {

        switch (  UIPopupList.current.value.Trim())
        {
            case "容易":
                grade=GameGrade.EASY;
                break;
            case "普通":
                grade=GameGrade.NORMAL;
                break;
            case "困难":
                grade = GameGrade.DIFFCULT;
                break;
            default:
                break;
        }
    }

    public void OnControlTypeChanged() {
        switch (UIPopupList.current.value.Trim())
        {
            case "键盘":
                controlType = ControlType.KEYBOARD;
                break;
            case "触摸":
                controlType = ControlType.TOUCH;
                break;
            case "鼠标":
                controlType = ControlType.MOUSE;
                break;
            default:
                break;
        }
    }
    public void OnFullScreenChanged() {
        IsFullScreen = UIToggle.current.value;
    }


    public void OnOptionButtonClick()
    {
        startOption.PlayForward(); //正向播放
        completeOption.PlayForward();
    }
    public void OnCompleteButtonClick()
    {
        startOption.PlayReverse(); //逆向播放   倒退播放
        completeOption.PlayReverse();
    }
}
/// <summary>
/// 游戏难度
/// </summary>
public enum GameGrade
{ 
   EASY,
    NORMAL,
    DIFFCULT

}
/// <summary>
/// 操作方式
/// </summary>
public enum ControlType
{ 
   KEYBOARD,
    TOUCH,
    MOUSE
}


