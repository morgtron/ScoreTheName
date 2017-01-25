using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public InputField inputField;
    public Text text;
    public LevelManager levelManager;
    public Animator anim;
    public Animator anim2;
    public int score = 0;
    TimerController scr_timerControl;

    public static GameManager instance = null;
    private string mySecretWord;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    

    private void Start()
    {
        
    }

    public void GetGuess()
    {
        string guess = inputField.text.ToUpper();
        Debug.Log(guess);
        if (guess != null) { 
            if (guess == mySecretWord)
            {
                anim.StopPlayback();
                anim.SetBool("winner", true);
                StopRotator();
                score += 1;
            } else
            {
                StopRotator();
                anim.StopPlayback();
                anim.SetBool("loser", true);
            }
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        text = GameObject.Find("SecretName").GetComponent<Text>();
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        anim = GameObject.Find("Canvas").GetComponent<Animator>();
        GetSecretWord();
    }

    public void GetSecretWord()
    {
        if (!inputField) {
            return;
        } else
        {
            mySecretWord = text.text;
        }
    }

    public void StopRotator()
    {
        anim2 = GameObject.Find("GradientRotator").GetComponent<Animator>();
        anim2.Stop();
       // scr_timerControl = GameObject.Find("Timer").GetComponent<TimerController>();
        //scr_timerControl.speed = 0;

    }

}
