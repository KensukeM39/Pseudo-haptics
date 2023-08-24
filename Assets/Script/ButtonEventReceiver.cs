using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventReceiver : MonoBehaviour
{
    public void OnButtonClicked()
    {
        Debug.Log("UIボタンがクリックされました！");
        // ここにボタンがクリックされた際の処理を追加
    }
}
