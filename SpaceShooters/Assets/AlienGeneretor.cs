using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienGeneretor : MonoBehaviour {
    public GameObject alien;
    //public GameObject ship;
    //public GameObject shootPosition;
    public GameObject[] spawnPoints;
    public float spawnTimer = 3;
    private bool canShoot = false;
    private int randomNumberAlien = 0;
    //private int randomNumberShip = 0;

    // Use this for initialization
    void Start()
    {
        //StartCoroutine(Shoot());
        StartCoroutine(Alien());
        // StartCoroutine(Ship());
    }

    // Update is called once per frame
    void Update()
    {

        if (canShoot == true && GameControl.instance.lose == false)
        {
            AliensGeneretor(alien, spawnPoints, randomNumberAlien);
        }


    }

    IEnumerator Alien()
    {
        // Debug.Log("Entro a la corrutina");
        yield return new WaitForSeconds(spawnTimer);
        randomNumberAlien = Random.Range(0, 7);
        canShoot = true;
    }



    private void AliensGeneretor(GameObject alien, GameObject[] spawnPoints, int randomNumberAlien)
    {
        GameObject go = (GameObject)Instantiate(alien, spawnPoints[randomNumberAlien].transform.position, spawnPoints[randomNumberAlien].transform.rotation);
        go.transform.Rotate(0,0,180);
        go.GetComponent<Rigidbody2D>().AddForce(transform.up * .2f, ForceMode2D.Impulse);
        canShoot = false;
        StartCoroutine(Alien());
    }


}
