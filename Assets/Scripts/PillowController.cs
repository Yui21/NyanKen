using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillowController : MonoBehaviour
{
    public GameObject uIPillowAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("まくらと衝突した！！！！");
            uIPillowAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("まくらから離れた！！！！");
            uIPillowAction.SetActive(false);
        }
    }
}
