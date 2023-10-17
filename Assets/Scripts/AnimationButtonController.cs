using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationButtonController : MonoBehaviour
{
    public Animator cuCatAnim;

    void Start()
    {
        //cuCatAnim = 
    }

    public void Cry()
    {
        //鳴くアニメーションスタート
        cuCatAnim.SetTrigger("isCry");

        //鳴き声の音声が再生される
    }
}
