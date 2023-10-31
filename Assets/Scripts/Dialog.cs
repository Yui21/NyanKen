using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    
    //「カードの詳細」と「ステージ詳細」のスクリプトです！！！！

    public GameObject dialog;

    private GameObject current;

    public void OpenDialog(GameObject detail)
    {
        current = detail; 

        dialog.SetActive(true);
        detail.SetActive(true);

    }

    public void CloseDialog()
    {
        dialog.SetActive(false);
        current.SetActive(false);
    }
}
