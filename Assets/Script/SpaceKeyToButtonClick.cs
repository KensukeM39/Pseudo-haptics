using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceKeyToButtonClick : MonoBehaviour
{
    public Button uiButton; // InspectorからUIボタンをアサイン

    void Update()
    {
        // スペースキーが押されたらUIボタンをクリックする
        if (Input.GetKeyDown(KeyCode.Space))
        {
            uiButton.onClick.Invoke();
        }
    }
}
