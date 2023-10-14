using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBoardControlloer : MonoBehaviour
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
            

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("段ボールから離れた！！！！");
            //uIPillowAction.SetActive(false);
        }
    }
}
