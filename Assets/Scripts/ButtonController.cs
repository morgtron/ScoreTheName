using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    public Image image;
    public Animator anim;

    public void SetStart()
    {
        anim.SetBool("isStarted", true);

    }

    public void SetRules()
    {
        anim.SetBool("rulesRead", true);

    }
}
