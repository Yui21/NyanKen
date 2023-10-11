using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelfController : MonoBehaviour
{
    public GameObject uIShelfAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("緑の棚と衝突！！！！");
            uIShelfAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("緑の棚から離れた！！！！");
            uIShelfAction.SetActive(false);
        }
    }
}
