using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    public GameObject timer;
    public Image image;
    public Animator anim;
    public Animator anim2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        image.color = timer.GetComponent<Image>().color;
    }

    public void SetStart()
    {
        anim.SetBool("isStarted", true);
        anim2.SetBool("isOffScreen", true);
    }

    public void SetRules()
    {
        anim.SetBool("rulesRead", true);
        anim2.SetBool("rulesRead", true);
    }
}
