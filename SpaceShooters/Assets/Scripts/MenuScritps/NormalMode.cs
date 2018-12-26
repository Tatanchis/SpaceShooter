using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalMode : MonoBehaviour {
    public void NormalModeScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
