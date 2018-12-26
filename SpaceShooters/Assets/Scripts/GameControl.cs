using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl instance;

    public bool lose = false;
    //private bool waitForDestroyAnimation = false;
    public bool nameWasSetted = false;
    public int life = 3;
    public float timer;
    public int timeLeft;
    public int score;
    public bool powerUp;

    public Text timerText;
    public Text lifeText;
    public Text scoreText;

    //Para inicializar la variable singleton GameControl
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }

    // Use this for initialization
    void Start () {
        powerUp = false;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (lose == false)
        {
            timeLeft = (int)timer;
            timerText.text = timeLeft.ToString();
        }
        lifeText.text = life.ToString();
        scoreText.text = score.ToString();
        if (life == 0){
            lose = true;
        }
    }
}
