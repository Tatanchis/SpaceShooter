using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour {
    public void ReturnToMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
