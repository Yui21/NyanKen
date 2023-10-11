using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupController : MonoBehaviour
{
    public GameObject uICupAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("コップと衝突した！！！！");
            uICupAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("コップから離れた！！！！");
            uICupAction.SetActive(false);
        }
    }
}
