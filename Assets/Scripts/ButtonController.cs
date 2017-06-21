using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public LevelManager levelManager;
    public Image image;
    public Animator anim;

    private void Awake()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    public void SetStart()
    {
        anim.SetBool("isStarted", true);        
    }

    public void SetRulesEasy()
    {
        anim.SetBool("rulesRead", true);
        levelManager.difficulty = 1;
    }

    public void SetRulesMedium()
    {
        anim.SetBool("rulesRead", true);
        levelManager.difficulty = 2;
    }

    public void SetRulesHard()
    {
        anim.SetBool("rulesRead", true);
        levelManager.difficulty = 3;
    }
}
