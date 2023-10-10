using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    public GameObject comicBooks;
    
    void OnTriggerStay(Collider other)
    {
        if(comicBooks.CompareTag("Player"))
        {
            Debug.Log("ヒット！！！！！");
        }
    }
}
