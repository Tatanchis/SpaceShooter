using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour {

    public GameObject asteroid;
    //public GameObject alien;
    //public GameObject ship;
    //public GameObject shootPosition;
    public GameObject[] spawnPoints;
    public float spawnTimer = 3;
    private bool canShoot = false;
    private int randomNumber = 0;
    //private int randomNumberAlien = 0;
    //private int randomNumberShip = 0;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Shoot());
        //StartCoroutine(Alien());
        //StartCoroutine(Ship());
    }

    // Update is called once per frame
    void Update()
    {

        if (canShoot == true && GameControl.instance.lose == false)
        {
            AsteroidsGeneretor(asteroid, spawnPoints, randomNumber);
            //AlienGeneretor(alien, spawnPoints, randomNumberAlien);
            //ShipGeneretor(ship, spawnPoints, randomNumberShip);
            /*
            if(randomNumber == 0)
            {
                AsteroidsGeneretor(asteroid,spawnpoints,randomNumber);
                GameObject go = (GameObject)Instantiate(asteroid, spawnpoints[0].transform.position, spawnpoints[0].transform.rotation);
                go.GetComponent<Rigidbody2D>().AddForce(transform.up * .1f, ForceMode2D.Impulse);
                canShoot = false;
                StartCoroutine(Shoot());
            }
            else if (randomNumber == 1){
                GameObject go = (GameObject)Instantiate(asteroid, spawnpoints[1].transform.position, spawnpoints[1].transform.rotation);
                go.GetComponent<Rigidbody2D>().AddForce(transform.up * .1f, ForceMode2D.Impulse);
                canShoot = false;
                StartCoroutine(Shoot());
            }
            else if (randomNumber == 2)
            {
                GameObject go = (GameObject)Instantiate(asteroid, spawnpoints[2].transform.position, spawnpoints[2].transform.rotation);
                go.GetComponent<Rigidbody2D>().AddForce(transform.up * .1f, ForceMode2D.Impulse);
                canShoot = false;
                StartCoroutine(Shoot());
            }
            else if (randomNumber == 3)
            {
                GameObject go = (GameObject)Instantiate(asteroid, spawnpoints[3].transform.position, spawnpoints[3].transform.rotation);
                go.GetComponent<Rigidbody2D>().AddForce(transform.up * .1f, ForceMode2D.Impulse);
                canShoot = false;
                StartCoroutine(Shoot());
            }
            else if (randomNumber == 4)
            {
                GameObject go = (GameObject)Instantiate(asteroid, spawnpoints[4].transform.position, spawnpoints[4].transform.rotation);
                go.GetComponent<Rigidbody2D>().AddForce(transform.up * .1f, ForceMode2D.Impulse);
                canShoot = false;
                StartCoroutine(Shoot());
            }
            else if (randomNumber == 5)
            {
                GameObject go = (GameObject)Instantiate(asteroid, spawnpoints[5].transform.position, spawnpoints[5].transform.rotation);
                go.GetComponent<Rigidbody2D>().AddForce(transform.up * .1f, ForceMode2D.Impulse);
                canShoot = false;
                StartCoroutine(Shoot());
            }
            else if (randomNumber == 6)
            {
                GameObject go = (GameObject)Instantiate(asteroid, spawnpoints[6].transform.position, spawnpoints[6].transform.rotation);
                go.GetComponent<Rigidbody2D>().AddForce(transform.up * .1f, ForceMode2D.Impulse);
                canShoot = false;
                StartCoroutine(Shoot());
            }*/
        }


    }

    IEnumerator Shoot()
    {
       // Debug.Log("Entro a la corrutina");
        yield return new WaitForSeconds(spawnTimer);
        randomNumber = Random.Range(0, 7);
        canShoot = true;
    }


    private void AsteroidsGeneretor(GameObject asteroid, GameObject [] spawnPoints, int randomNumber)
    {
        GameObject go = (GameObject)Instantiate(asteroid, spawnPoints[randomNumber].transform.position, spawnPoints[randomNumber].transform.rotation);
        go.GetComponent<Rigidbody2D>().AddForce(transform.up * .1f, ForceMode2D.Impulse);
        canShoot = false;
        StartCoroutine(Shoot());
    }

}
