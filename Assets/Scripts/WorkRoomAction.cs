using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkRoomAction : MonoBehaviour
{
    public GameObject uIAirConAction;
    public GameObject uIComicBookAction;
    public GameObject uICupAction;
    public GameObject uIGarbageCanAction;
    public GameObject uIPillowAction;
    public GameObject uIPCAction;
    public GameObject uIChairAction;
    public GameObject uIShelfAction;
    public GameObject uIOshiireAction;
    public GameObject uIPosterAction;
    public GameObject uICodeAction;


    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            if(gameObject.name == "airCon_Con")
            {
                Debug.Log("エアコンのリモコンと衝突した！！！！");
                uIAirConAction.SetActive(true);
            }

            if(gameObject.name == "comicBook")
            {
                Debug.Log("漫画の山と衝突した！！！！");
                uIComicBookAction.SetActive(true);
            }
            if(gameObject.name == "cup")
            {
                Debug.Log("コップと衝突した！！！！");
                uICupAction.SetActive(true);
            }
            
            if(gameObject.name == "garbageCan")
            {
                Debug.Log("ゴミ箱と衝突した！！！！");
                uIGarbageCanAction.SetActive(true);
            }
            if(gameObject.name == "pillow")
            {
                Debug.Log("枕と衝突した！！！！");
                uIPillowAction.SetActive(true);
            }
            
            if(gameObject.name == "PC")
            {
                Debug.Log("PCと衝突した！！！！");
                uIPCAction.SetActive(true);
            }

            if(gameObject.name == "backRest")
            {
                Debug.Log("いすと衝突した！！！！");
                uIChairAction.SetActive(true);
            }

            if(gameObject.name == "shelf")
            {
                Debug.Log("緑の棚と衝突した！！！！");
                uIShelfAction.SetActive(true);
            }

            if(gameObject.name == "oshiire")
            {
                Debug.Log("押入れと衝突した！！！！");
                uIOshiireAction.SetActive(true);
            }

            if(gameObject.name == "poster")
            {
                Debug.Log("ポスターと衝突した！！！！");
                uIPosterAction.SetActive(true);
            }

            if(gameObject.name == "code")
            {
                Debug.Log("コードと衝突した！！！！");
                uICodeAction.SetActive(true);
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
                uIAirConAction.SetActive(false);
            }

            if(gameObject.name == "comicBook")
            {
                Debug.Log("漫画の山から離れた！！！！");
                uIComicBookAction.SetActive(false);
            }

            if(gameObject.name == "cup")
            {
                Debug.Log("コップから離れた！！！！");
                uICupAction.SetActive(false);
            }
            
            if(gameObject.name == "garbageCan")
            {
                Debug.Log("ゴミ箱から離れた！！！！");
                uIGarbageCanAction.SetActive(false);
            }

            if(gameObject.name == "pillow")
            {
                Debug.Log("枕から離れた！！！！");
                uIPillowAction.SetActive(false);
            }
            
            if(gameObject.name == "PC")
            {
                Debug.Log("PCから離れた！！！！");
                uIPCAction.SetActive(false);
            }

            if(gameObject.name == "backRest")
            {
                Debug.Log("いすから離れた！！！！");
                uIChairAction.SetActive(false);
            }

            if(gameObject.name == "shelf")
            {
                Debug.Log("緑の棚から離れた！！！！");
                uIShelfAction.SetActive(false);
            }

            if(gameObject.name == "oshiire")
            {
                Debug.Log("押入れから離れた！！！！");
                uIOshiireAction.SetActive(false);
            }

            if(gameObject.name == "poster")
            {
                Debug.Log("ポスターから離れた！！！！");
                uIPosterAction.SetActive(false);
            }

            if(gameObject.name == "code")
            {
                Debug.Log("コードから離れた！！！！");
                uICodeAction.SetActive(false);
            }
        }
    }
}
