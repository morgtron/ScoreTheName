﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowKeyboard : MonoBehaviour {

    public InputField inputField;

    public void DoShowKeyboard()
    {
        inputField.ActivateInputField();
    }
}
