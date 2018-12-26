using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneMode : MonoBehaviour {

    public void PhoneModeScene()
    {
        SceneManager.LoadScene("PhoneMovement");
    }
}
