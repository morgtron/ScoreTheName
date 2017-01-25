using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

    private GameManager gameManager;
    public InputField inputField;

	// Use this for initialization
	void Start () {

    }

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        inputField.onEndEdit.AddListener(delegate { GetGuess(); });
    }

    // Update is called once per frame
    void Update () {

	}

    private void GetGuess()
    {
        gameManager.GetGuess();
    }
}


