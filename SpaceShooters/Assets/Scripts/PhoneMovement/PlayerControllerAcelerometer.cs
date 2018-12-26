using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerAcelerometer : MonoBehaviour {

    private Animator shipAnimator;
    // Use this for initialization
    void Start () {
        shipAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        float temp = Input.acceleration.x;
        transform.Translate(temp/2,0,0);
        if (temp< 0)
        {
            shipAnimator.SetTrigger("Left");
            shipAnimator.ResetTrigger("Right");
            shipAnimator.ResetTrigger("Idle");
        }
        if (temp > 0)
        {
            shipAnimator.SetTrigger("Right");
            shipAnimator.ResetTrigger("Left");
            shipAnimator.ResetTrigger("Idle");
        }

        if (GameControl.instance.lose == true)
        {
            shipAnimator.SetTrigger("Destroy");
            Destroy(this.gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        }
    }
}
