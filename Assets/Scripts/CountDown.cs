using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] Text textCountdown = default;
    public GameObject startButton;

    //2分タイマーに関係するオブジェクト
    public GameObject timer;
 
	
 
	public void OnClickButtonStart()
	{
		StartCoroutine(CountdownCoroutine());
	}
 
	IEnumerator CountdownCoroutine()
	{
		

        startButton.SetActive(false);
 
		textCountdown.text = "3";
		yield return new WaitForSeconds(1.0f);
 
		textCountdown.text = "2";
		yield return new WaitForSeconds(1.0f);
 
		textCountdown.text = "1";
		yield return new WaitForSeconds(1.0f);
		
		textCountdown.text = "GO!";
		yield return new WaitForSeconds(1.0f);

        textCountdown.text = "";

        
		TimerCountDown();
        yield return new WaitForSeconds(1.0f);

        
	}

    public void TimerCountDown()
    {
        //2分のタイマーに関係するものをアクティブにしてタイマーを開始させる
        timer.SetActive(true);
    }
}
