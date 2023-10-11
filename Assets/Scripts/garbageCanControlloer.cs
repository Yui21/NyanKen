using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbageCanControlloer : MonoBehaviour
{
    public GameObject uIGarbageCanAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("ゴミ箱と衝突！！！！");
            uIGarbageCanAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ゴミ箱から離れた！！！！");
            uIGarbageCanAction.SetActive(false);
        }
    }
}
