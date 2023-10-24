using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnIntController : MonoBehaviour
{
    
    //これはボタンを押せなくするスクリプトです。
    
    public GameObject jumpBtn;
    public GameObject sprintBtn;
    public GameObject  tpsTofpsBtn;
    public GameObject cryBtn;
    public GameObject sleepBtn;
    public GameObject getUpBtn;


    void Start()
    {
        jumpBtn.GetComponent<Button>().interactable = false;
        sprintBtn.GetComponent<Button>().interactable = false;
        tpsTofpsBtn.GetComponent<Button>().interactable = false;
        cryBtn.GetComponent<Button>().interactable = false;
        sleepBtn.GetComponent<Button>().interactable = false;
        getUpBtn.GetComponent<Button>().interactable = false;
        
    }

    public void BtnIntTrue()
    {
        jumpBtn.GetComponent<Button>().interactable = true;
        sprintBtn.GetComponent<Button>().interactable = true;
        tpsTofpsBtn.GetComponent<Button>().interactable = true;
        cryBtn.GetComponent<Button>().interactable = true;
        sleepBtn.GetComponent<Button>().interactable = true;
        getUpBtn.GetComponent<Button>().interactable = true;

    }
}
