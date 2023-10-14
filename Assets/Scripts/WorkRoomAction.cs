using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkRoomAction : MonoBehaviour
{
    //public GameObject uIPillowAction;

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            if(gameObject.name == "airCon_Con")
            {
                Debug.Log("エアコンのリモコンと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "comicBook")
            {
                Debug.Log("漫画の山と衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            if(gameObject.name == "cup")
            {
                Debug.Log("コップと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            
            if(gameObject.name == "garbageCan")
            {
                Debug.Log("ゴミ箱と衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            if(gameObject.name == "pillow")
            {
                Debug.Log("枕と衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            
            if(gameObject.name == "PC")
            {
                Debug.Log("PCと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "backRest")
            {
                Debug.Log("いすと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "shelf")
            {
                Debug.Log("緑の棚と衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "oshiire")
            {
                Debug.Log("押入れと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "poster")
            {
                Debug.Log("ポスターと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "code")
            {
                Debug.Log("コードと衝突した！！！！");
                //uIPillowAction.SetActive(true);
            }
            

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(gameObject.name == "airCon_Con")
            {
                Debug.Log("エアコンのリモコンから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "comicBook")
            {
                Debug.Log("漫画の山から離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "cup")
            {
                Debug.Log("コップから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }
            
            if(gameObject.name == "garbageCan")
            {
                Debug.Log("ゴミ箱から離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "pillow")
            {
                Debug.Log("枕から離れた！！！！");
                //uIPillowAction.SetActive(true);
            }
            
            if(gameObject.name == "PC")
            {
                Debug.Log("PCから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "backRest")
            {
                Debug.Log("いすから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "shelf")
            {
                Debug.Log("緑の棚から離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "oshiire")
            {
                Debug.Log("押入れから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "poster")
            {
                Debug.Log("ポスターから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }

            if(gameObject.name == "code")
            {
                Debug.Log("コードから離れた！！！！");
                //uIPillowAction.SetActive(true);
            }
        }
    }
}
