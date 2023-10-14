using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaController : MonoBehaviour
{
    //public GameObject uIPillowAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("ルンバと衝突した！！！！");
            //uIPillowAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ルンバから離れた！！！！");
            //uIPillowAction.SetActive(false);
        }
    }
}
