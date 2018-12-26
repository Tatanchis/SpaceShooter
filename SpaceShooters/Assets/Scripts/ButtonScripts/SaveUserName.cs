using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveUserName : MonoBehaviour {

    public InputField userName;
    public Button continueButton;
    string inputText;

    private void Start()
    {
        inputText = PlayerPrefs.GetString("UserName");
        userName.text = inputText;
    }

    public void SaveName()
    {
        inputText = userName.text;
        PlayerPrefs.SetString("UserName", inputText);
        GameControl.instance.nameWasSetted = true;
        continueButton.gameObject.SetActive(true);
        Debug.Log("El nombre actual es "+ PlayerPrefs.GetString("UserName"));
    }
}
