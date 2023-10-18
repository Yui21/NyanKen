using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationButtonController : MonoBehaviour
{
    public Animator cuCatAnim;
    public AudioClip cat_cry;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    public void Cry()
    {
        //鳴くアニメーションスタート
        cuCatAnim.SetTrigger("isCry");

        //鳴き声の音声が再生される
        audioSource.PlayOneShot(cat_cry);
    }

    public void Sleep()
    {
        //寝るアニメーションスタート
        cuCatAnim.SetTrigger("isSleep");

        
    }

    public void GetUp()
    {
        //起きるアニメーションスタート
        cuCatAnim.SetTrigger("isGetUp");

        
    }
}
