using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideUserNameScreen : MonoBehaviour {

    public GameObject userScreen;
    public InputField userNameInputField;
    public Button saveButton;
    public Button continueButton;
    //
    public GameObject scoresScreen;
    public Text matchScore;
    public Text matchTime;
    public Text bestScore;
    public Text bestScoreName;
    public Text bestTime;
    public Text bestTimeName;
    public Button playAgain;
    public Button mainMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HideUserNameMenu()
    {
        userScreen.gameObject.SetActive(false);
        userNameInputField.gameObject.SetActive(false);
        saveButton.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        //
        scoresScreen.gameObject.SetActive(true);
        matchScore.gameObject.SetActive(true);
        matchTime.gameObject.SetActive(true);
        bestScore.gameObject.SetActive(true);
        bestScoreName.gameObject.SetActive(true);
        bestTime.gameObject.SetActive(true);
        bestTimeName.gameObject.SetActive(true);
        playAgain.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(true);
    }
}
