using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void toHome()
    {
        SceneManager.LoadScene("#home");
    }

    public void toCard()
    {
        SceneManager.LoadScene("#card");
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
