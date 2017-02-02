using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public LevelManager levelManager;

    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        levelManager = FindObjectOfType<LevelManager>().GetComponent<LevelManager>();
    }

    public void PlayClip()
    {
        anim.Play(0);
    }

    public void LoadNextLevel()
    {
        levelManager.LoadNextLevel();
    }

    public void LoadLevelLose()
    {
        levelManager.LoadLevel("End");
    }
}
