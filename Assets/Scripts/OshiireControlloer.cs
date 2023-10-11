using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OshiireControlloer : MonoBehaviour
{
    public GameObject uIOshiireAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("押入れと衝突した！！！！");
            uIOshiireAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("押入れから離れた！！！！");
            uIOshiireAction.SetActive(false);
        }
    }
}
