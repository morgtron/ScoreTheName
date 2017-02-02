using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{

    private GameManager gameManager;
    public InputField inputField;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        inputField.onEndEdit.AddListener(delegate { GetGuess(); });
    }

    private void GetGuess()
    {
        gameManager.GetGuess();
    }
}


