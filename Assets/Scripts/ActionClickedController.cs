using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionClickedController : MonoBehaviour
{
    //アクションボタンがクリックされた時の処理をここに記入

    //#workRoom
    public GameObject airConClear;
    public GameObject garbageCanClear;
    public GameObject pcClear;
    public GameObject pillowClear;
    public GameObject oshiireClear;
    public GameObject comicBookClear;
    public GameObject shelfClear;
    public GameObject posterClear;
    public GameObject chairClear;
    public GameObject cupClear;
    public GameObject codeClear;

    //#livingRoom
    public GameObject cardBoardClear;
    public GameObject doorClear;
    public GameObject waterDishClear;
    public GameObject tVClear;
    public GameObject pianoClear;
    public GameObject roombaClear;
    public GameObject teddyBearPinkClear;
    public GameObject teddyBearBlueClear;



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

            if(gameObject.name == "PC")
            {
                Debug.Log("PCのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(pcClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "pillow")
            {
                Debug.Log("まくらのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(pillowClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "oshiire")
            {
                Debug.Log("押入れのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(oshiireClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "comicBook")
            {
                Debug.Log("漫画のアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(comicBookClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "shelf")
            {
                Debug.Log("緑の棚のアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(shelfClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "poster")
            {
                Debug.Log("ポスターのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(posterClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "backRest")
            {
                Debug.Log("椅子のアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(chairClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "cup")
            {
                Debug.Log("コップのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(cupClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "code")
            {
                Debug.Log("コードのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(codeClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }


            //#livingRoom
            if(gameObject.name == "cardBoard")
            {
                Debug.Log("段ボールのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(cardBoardClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "door")
            {
                Debug.Log("ドアのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(doorClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "waterDish")
            {
                Debug.Log("水入れのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(waterDishClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "TV")
            {
                Debug.Log("テレビのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(tVClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "piano")
            {
                Debug.Log("ピアノのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(pianoClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "roomba")
            {
                Debug.Log("ルンバのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(roombaClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "teddyBearPinkHead")
            {
                Debug.Log("ピンクくまのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(teddyBearPinkClear, 2f)); // maruを表示させ、２秒後に非表示

                //仮でオブジェクトを消す
                //this.gameObject.SetActive (false);

                //ゴミ箱のアクションボタンも消す
            }

            if(gameObject.name == "teddyBearBlueHead")
            {
                Debug.Log("水色くまのアクション！！！！");

                //2秒くらいだけ表示させたい
                //garbageCanClear.SetActive(true);
                //本当はこのテロップにアニメーションつけるから子ルーチンは使わないかも？
                StartCoroutine(ShowImageSecond(teddyBearBlueClear, 2f)); // maruを表示させ、２秒後に非表示

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
