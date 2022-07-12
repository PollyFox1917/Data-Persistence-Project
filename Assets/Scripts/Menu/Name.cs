using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    private InputField ifield;

    private void Start()
    {
        ifield = GetComponent<InputField>();
    }

    // Start is called before the first frame update
    public void onNameChange(string name)
    {
        PlayerPrefs.SetString("name",ifield.text);
    }
}
