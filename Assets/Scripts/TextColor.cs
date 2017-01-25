using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColor : MonoBehaviour {

    public GameObject timer;
    private Color myColor;
    public Text text;

    // Use this for initialization
    void Start () {
        Color myColor = GetComponent<Text>().color;
	}
	
	// Update is called once per frame
	void Update () {
        text.color = timer.GetComponent<Image>().color;
	}
}
