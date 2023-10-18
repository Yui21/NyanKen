using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionClickedController : MonoBehaviour
{
    //アクションボタンがクリックされた時の処理をここに記入
    public GameObject airConClear;
    public GameObject garbageCanClear;
    public GameObject pcClear;
    public GameObject pillowClear;
    public GameObject OshiireClear;
    public GameObject comicBookClear;
    public GameObject shelfClear;
    public GameObject posterCanClear;
    public GameObject chairClear;
    public GameObject cupCanClear;


    public void ActionClicked()
    {
        if(gameObject.name == "airCon_Con")
            {
                Debug.Log("エアコンリモコンのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(airConClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }
        
        if(gameObject.name == "garbageCan")
            {
                Debug.Log("ゴミ箱のアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(garbageCanClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }
    }

    // 引数で当たられたオブジェクトを表示し、引数の秒数後に非表示にするコルーチン
    IEnumerator ShowImageSecond(GameObject targetObj, float sec) 
    {
        targetObj.SetActive(true); //引数で指定されたオブジェクトを表示する
        yield return new WaitForSeconds(sec); // 引数で指定された秒数待つ
        targetObj.SetActive(false); //引数で指定されたオブジェクトを非表示にする
    }

}
