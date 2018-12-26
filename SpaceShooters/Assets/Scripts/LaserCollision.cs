using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Asteroid")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            GameControl.instance.score += 10;
        }
        if (col.gameObject.tag == "Alien")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            GameControl.instance.score += 50;
        }
        if (col.gameObject.tag == "OtherShip")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            GameControl.instance.score += 20;
        }
    }
}

