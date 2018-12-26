using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGeneretor : MonoBehaviour {

    public GameObject ship;
    //public GameObject shootPosition;
    public GameObject[] spawnPoints;
    public float spawnTimer = 3;
    private bool canShoot = false;
    private int randomNumberShip = 0;

    // Use this for initialization
    void Start()
    {
        //StartCoroutine(Shoot());
        //StartCoroutine(Alien());
        StartCoroutine(Ship());
    }

    // Update is called once per frame
    void Update()
    {

        if (canShoot == true && GameControl.instance.lose == false)
        {
            AliensGeneretor(ship, spawnPoints, randomNumberShip);
        }


    }

    IEnumerator Ship()
    {
        // Debug.Log("Entro a la corrutina");
        yield return new WaitForSeconds(spawnTimer);
        randomNumberShip = Random.Range(0, 7);
        canShoot = true;
    }



    private void AliensGeneretor(GameObject ship, GameObject[] spawnPoints, int randomNumberShip)
    {
        GameObject go = (GameObject)Instantiate(ship, spawnPoints[randomNumberShip].transform.position, spawnPoints[randomNumberShip].transform.rotation);
        go.GetComponent<Rigidbody2D>().AddForce(transform.up * .2f, ForceMode2D.Impulse);
        canShoot = false;
        StartCoroutine(Ship());
    }


}
