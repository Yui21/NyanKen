using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comicBookController : MonoBehaviour
{
    public GameObject uIComicBookAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            //プレイヤーがゴリラ圏内にいるときの処理
            //ボタン等を設置したPanelを表示させる。
            //Panel.SetActive(true);
            Debug.Log("ヒット！！！！");
            uIComicBookAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //プレイヤーがゴリラ圏内から出た時の処理
            //Panelを非表示にする。
            //Panel.SetActive(false);
            Debug.Log("出た！！！！");
            uIComicBookAction.SetActive(false);
        }
    }
}
