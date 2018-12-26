using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Asteroid" || col.gameObject.tag == "OtherShip" || col.gameObject.tag == "Alien")
        {
            Destroy(col.gameObject);
            GameControl.instance.life -= 1;
        }

        if (col.gameObject.tag == "PowerUp")
        {
            Destroy(col.gameObject);
            GameControl.instance.powerUp = true;
        }

        if (GameControl.instance.life == 0){
           // Destroy(this.gameObject);
        }
    }
}
