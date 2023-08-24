using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject object1; // 1つ目のオブジェクト
    public GameObject object2; // 2つ目のオブジェクト
    public GameObject object3; // 3つ目のオブジェクト

    private int currentObject = 1; // 現在表示中のオブジェクト

    private void Start()
    {
        // 初期状態で1つ目のオブジェクトを表示、2つ目と3つ目のオブジェクトを非表示にする
        object1.SetActive(true);
        object2.SetActive(false);
        object3.SetActive(false);
    }

    private void Update()
    {
        // エンターキーでオブジェクトを入れ替える
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Swap();
        }
    }

    // オブジェクトを入れ替える処理
    private void Swap()
    {
        // 現在表示中のオブジェクトを次のオブジェクトに更新
        currentObject = (currentObject % 3) + 1;

        // オブジェクトを切り替える
        switch (currentObject)
        {
            case 1:
                object1.SetActive(true);
                object2.SetActive(false);
                object3.SetActive(false);
                break;
            case 2:
                object1.SetActive(false);
                object2.SetActive(true);
                object3.SetActive(false);
                break;
            case 3:
                object1.SetActive(false);
                object2.SetActive(false);
                object3.SetActive(true);
                break;
        }
    }
}
