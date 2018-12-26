using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyBulletsAndAsteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Asteroid" || col.gameObject.tag == "Laser" ||
            col.gameObject.tag == "Alien" || col.gameObject.tag == "OtherShip" ||
            col.gameObject.tag == "PowerUp")
        {
            Destroy(col.gameObject);
        }

    }
}
