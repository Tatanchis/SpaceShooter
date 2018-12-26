using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public Button leftShootButton;
    public Button rightShootButton;
    public Button centerShootButton;
    public bool leftButton;
    public bool rightButton;
    private Vector2 movement;

    private Animator shipAnimator;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        shipAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Button btnLeft = leftShootButton.GetComponent<Button>();
        btnLeft.onClick.AddListener(LeftClick);
        Button btnRight = rightShootButton.GetComponent<Button>();
        btnRight.onClick.AddListener(RightClick);
        Button btnCenter = centerShootButton.GetComponent<Button>();
        btnCenter.onClick.AddListener(CenterClick);

        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = movement.normalized * speed;

        if(leftButton == true)
        {
            movement = new Vector2(-1,0);
            moveVelocity = movement.normalized * speed;
        }
        if (rightButton == true)
        {
            movement = new Vector2(1, 0);
            moveVelocity = movement.normalized * speed;
        }
        if (GameControl.instance.lose == true) {
            shipAnimator.SetTrigger("Destroy");
           Destroy(this.gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void LeftClick()
    {
        leftButton = true;
        rightButton = false;
        shipAnimator.SetTrigger("Left");
        shipAnimator.ResetTrigger("Right");
        shipAnimator.ResetTrigger("Idle");
    }

    private void RightClick()
    {
        rightButton = true;
        leftButton = false;
        shipAnimator.SetTrigger("Right");
        shipAnimator.ResetTrigger("Idle");
        shipAnimator.ResetTrigger("Left");

    }

    private void CenterClick()
    {
        rightButton = false;
        leftButton = false;
        shipAnimator.SetTrigger("Idle");
        shipAnimator.ResetTrigger("Right");
        shipAnimator.ResetTrigger("Left");
    }
}
