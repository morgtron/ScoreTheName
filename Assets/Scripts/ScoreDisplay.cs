using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    private GameManager gameManager;
    public Text text;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        text.text = gameManager.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
