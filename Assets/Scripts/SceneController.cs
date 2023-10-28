using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void toTitle()
    {
        SceneManager.LoadScene("#title");
    }

    public void toHome()
    {
        SceneManager.LoadScene("#home");
    }

    public void toCard()
    {
        SceneManager.LoadScene("#card");
    }

    public void toStageSelect()
    {
        SceneManager.LoadScene("#stageSelect");
    }

    public void toWorkRoom()
    {
        SceneManager.LoadScene("#workRoom");
    }

    public void toLivingRoom()
    {
        SceneManager.LoadScene("#livingRoom");
    }

    public void toKitcheRoom()
    {
        SceneManager.LoadScene("#kitchenRoom");
    }
}
