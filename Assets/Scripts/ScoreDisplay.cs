using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    private GameManager gameManager;
    public Text text;

    // Morgan and Christian are pure absolute jam gods
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (gameManager.score < 10)
        {
            text.text = "0" + gameManager.score.ToString();
        }
        else if (gameManager.score >= 10)
        {
            text.text = gameManager.score.ToString();
        }

    }

}
