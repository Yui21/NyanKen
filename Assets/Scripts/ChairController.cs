using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairController : MonoBehaviour
{
    public GameObject uIChairAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("いすと衝突した！！！！");
            uIChairAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("いすから離れた！！！！");
            uIChairAction.SetActive(false);
        }
    }
}
