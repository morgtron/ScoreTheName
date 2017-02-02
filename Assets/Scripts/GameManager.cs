using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public InputField inputField;
    public Text text;
    public LevelManager levelManager;
    public Animator anim;
    public int score = 0;

    public static GameManager instance = null;
    private string mySecretWord;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void GetGuess()
    {
        string guess = inputField.text.ToUpper();
        Debug.Log(guess);
        if (guess != null)
        {
            if (guess == mySecretWord)
            {
                anim.StopPlayback();
                anim.SetBool("winner", true);
                score += 1;
            }
            else
            {
                anim.StopPlayback();
                anim.SetBool("loser", true);
            }
        }
    }

    private void OnLevelWasLoaded()
    {
        Scene myScene = SceneManager.GetActiveScene();
        if (myScene.buildIndex > 0 && myScene.buildIndex < 13)
        {
            inputField = GameObject.Find("InputField").GetComponent<InputField>();
            text = GameObject.Find("SecretName").GetComponent<Text>();
            levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
            anim = GameObject.Find("Canvas").GetComponent<Animator>();
            GetSecretWord();
        }
    }

    public void GetSecretWord()
    {
        if (!inputField)
        {
            return;
        }
        else
        {
            mySecretWord = text.text;
        }
    }



}
