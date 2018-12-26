using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    public bool oneTimeCall = true;
    public GameObject userScreen;
    public InputField userNameInputField;
    public Button saveButton;
    public Button continueButton;
	
	// Update is called once per frame
	void Update () {
        if (GameControl.instance.lose == true && oneTimeCall == true){
            StartCoroutine(WaitForDie());
            oneTimeCall = false;
        }


	}

    private IEnumerator WaitForDie()
    {
        yield return new WaitForSeconds(2);
        userScreen.gameObject.SetActive(true);
        userNameInputField.gameObject.SetActive(true);
        saveButton.gameObject.SetActive(true);
        //continueButton.gameObject.SetActive(true);

    }
}
