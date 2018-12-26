using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFinalScores : MonoBehaviour {

    public Text matchScore;
    public Text matchTime;
    public Text bestScore;
    public Text bestScoreName;
    public Text bestTime;
    public Text bestTimeName;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameControl.instance.lose == true && GameControl.instance.nameWasSetted == true ){
            SetScoresValues();
        }
	}

    private void SetScoresValues(){
        matchScore.text = GameControl.instance.score.ToString();
        matchTime.text = GameControl.instance.timeLeft.ToString();
        if (GameControl.instance.score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", GameControl.instance.score);
            PlayerPrefs.SetString("BestScoreUserName", PlayerPrefs.GetString("UserName"));
        }
        if (GameControl.instance.timeLeft > PlayerPrefs.GetInt("BestTime"))
        {
            PlayerPrefs.SetInt("BestTime", GameControl.instance.timeLeft);
            PlayerPrefs.SetString("BestTimeUserName", PlayerPrefs.GetString("UserName"));
        }
        bestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
        bestScoreName.text = PlayerPrefs.GetString("BestScoreUserName");
        bestTime.text = PlayerPrefs.GetInt("BestTime").ToString();
        bestTimeName.text = PlayerPrefs.GetString("BestTimeUserName");
    }
}
