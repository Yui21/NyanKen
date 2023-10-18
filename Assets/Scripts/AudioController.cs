using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip cat_cry;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    //「CRY」ボタンを押したら鳴き声再生
    public void Cry()
    {
        audioSource.PlayOneShot(cat_cry);
    }
}
