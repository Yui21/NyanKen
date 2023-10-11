using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comicBookController : MonoBehaviour
{
    public GameObject uIComicBookAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("漫画の山と衝突！！！！");
            uIComicBookAction.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("漫画の山から離れた！！！！");
            uIComicBookAction.SetActive(false);
        }
    }
}
