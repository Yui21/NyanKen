using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirConController : MonoBehaviour
{
    public GameObject uIAirConAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("リモコンと衝突した！！！！");
            uIAirConAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("リモコンから離れた！！！！");
            uIAirConAction.SetActive(false);
        }
    }
}
