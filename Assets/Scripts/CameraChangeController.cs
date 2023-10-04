using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChangeController : MonoBehaviour
{
    //TPS関係
    public GameObject playerCameraRoot;
    public GameObject mainCamera;
    public GameObject playerFollowCamera;
    public GameObject uICanvasTps;

    //FPS関係
    public GameObject catCameraRoot;
    public GameObject catEyeCamera;
    public GameObject uICanvasFps;

    //TPS・FPS両方に関係
    public GameObject cuCat;
    
    //スクリプト関係
    private FirstPersonController fpsScript;
    private ThirdPersonController tpsScript;

    private Test testScript; //これはできた
    
    void Start()
    {
        // fpsScript = GameObject.Find("cu_cat").GetComponent<FirstPersonController>();
        // tpsScript = GameObject.Find("cu_cat").GetComponent<ThirdPersonController>();

        //最初はFPS関係は全て非アクティブ
        catCameraRoot.SetActive(false);
        catEyeCamera.SetActive(false);
        uICanvasFps.SetActive(false);
        cuCat.GetComponent<FirstPersonController>().SetActive(false);
        

        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.C))//「C」を押してる間はFPSになる
        {
            //FPSになる
            catCameraRoot.SetActive(true);
            catEyeCamera.SetActive(true);
            uICanvasFps.SetActive(true);
            cuCat.GetComponent<FirstPersonController>().enabled = true;

            //テストで試した。これは実行できた
            cuCat.GetComponent<Test>().enabled = true;
        

            playerCameraRoot.SetActive(false);
            mainCamera.SetActive(false);
            playerFollowCamera.SetActive(false);
            uICanvasTps.SetActive(false);
            cuCat.GetComponent<ThirdPersonController>().enabled = false;
            

        }
        else
        {
            //TPSに戻る
            playerCameraRoot.SetActive(true);
            mainCamera.SetActive(true);
            playerFollowCamera.SetActive(true);
            uICanvasTps.SetActive(true);
            cuCat.GetComponent<ThirdPersonController>().enabled = true;

            catCameraRoot.SetActive(false);
            catEyeCamera.SetActive(false);
            uICanvasFps.SetActive(false);
            cuCat.GetComponent<FirstPersonController>().enabled = false;

        }
    }
}
