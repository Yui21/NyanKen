using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomAction : MonoBehaviour
{
    public GameObject uICardBoardAction;
    public GameObject uIRoombaAction;
    public GameObject uIDoorAction;
    public GameObject uIWaterDishAction;
    public GameObject uIteddyBearPinkHeadAction;
    public GameObject uIteddyBearBlueHeadAction;
    public GameObject uITVAction;
    

    void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            if(gameObject.name == "cardboard")
            {
                Debug.Log("段ボールと衝突した！！！！");
                uICardBoardAction.SetActive(true);
            }

            if(gameObject.name == "roomba")
            {
                Debug.Log("ルンバと衝突した！！！！");
                uIRoombaAction.SetActive(true);
            }
            if(gameObject.name == "door")
            {
                Debug.Log("ドアと衝突した！！！！");
                uIDoorAction.SetActive(true);
            }
            
            if(gameObject.name == "waterDish")
            {
                Debug.Log("水入れと衝突した！！！！");
                uIWaterDishAction.SetActive(true);
            }
            if(gameObject.name == "teddyBearPinkHead")
            {
                Debug.Log("ピンクのくまと衝突した！！！！");
                uIteddyBearPinkHeadAction.SetActive(true);
            }
            
            if(gameObject.name == "teddyBearBlueHead")
            {
                Debug.Log("水色のくまと衝突した！！！！");
                uIteddyBearBlueHeadAction.SetActive(true);
            }

            if(gameObject.name == "TV")
            {
                Debug.Log("TVと衝突した！！！！");
                uITVAction.SetActive(true);
            }
            

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(gameObject.name == "cardboard")
            {
                Debug.Log("段ボールから離れた！！！！");
                uICardBoardAction.SetActive(false);
            }

            if(gameObject.name == "roomba")
            {
                Debug.Log("ルンバから離れた！！！！");
                uIRoombaAction.SetActive(false);
            }
            if(gameObject.name == "door")
            {
                Debug.Log("ドアから離れた！！！！");
                uIDoorAction.SetActive(false);
            }
            
            if(gameObject.name == "waterDish")
            {
                Debug.Log("水入れから離れた！！！！");
                uIWaterDishAction.SetActive(false);
            }
            if(gameObject.name == "teddyBearPinkHead")
            {
                Debug.Log("ピンクのくまから離れた！！！！");
                uIteddyBearPinkHeadAction.SetActive(false);
            }
            
            if(gameObject.name == "teddyBearBlueHead")
            {
                Debug.Log("水色のくまから離れた！！！！");
                uIteddyBearBlueHeadAction.SetActive(false);
            }

            if(gameObject.name == "TV")
            {
                Debug.Log("TVから離れた！！！！");
                uITVAction.SetActive(false);
            }
        }
    }
}
