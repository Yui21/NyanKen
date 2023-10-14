using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomAction : MonoBehaviour
{
    //public GameObject uIPillowAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            if(gameObject.name == "cardboard")
            {
                Debug.Log("段ボールと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "roomba")
            {
                Debug.Log("ルンバと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            if(gameObject.name == "door")
            {
                Debug.Log("ドアと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            
            if(gameObject.name == "waterDish")
            {
                Debug.Log("水入れと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            if(gameObject.name == "teddyBearPinkHead")
            {
                Debug.Log("ピンクのくまと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            
            if(gameObject.name == "teddyBearBlueHead")
            {
                Debug.Log("水色のくまと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "TV")
            {
                Debug.Log("TVと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(gameObject.name == "cardboard")
            {
                Debug.Log("段ボールから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "roomba")
            {
                Debug.Log("ルンバから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }
            if(gameObject.name == "door")
            {
                Debug.Log("ドアから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }
            
            if(gameObject.name == "waterDish")
            {
                Debug.Log("水入れから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }
            if(gameObject.name == "teddyBearPinkHead")
            {
                Debug.Log("ピンクのくまから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }
            
            if(gameObject.name == "teddyBearBlueHead")
            {
                Debug.Log("水色のくまから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "TV")
            {
                Debug.Log("TVから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }
        }
    }
}
