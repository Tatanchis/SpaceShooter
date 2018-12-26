using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGeneretor : MonoBehaviour {

    public GameObject powerUp;
    //public GameObject ship;
    //public GameObject shootPosition;
    public GameObject[] spawnPoints;
    public float spawnTimer = 3;
    private bool canShoot = false;
    private int randomNumberPowerUp = 0;
    //private int randomNumberShip = 0;

    // Use this for initialization
    void Start()
    {
        //StartCoroutine(Shoot());
        StartCoroutine(PowerUp());
        // StartCoroutine(Ship());
    }

    // Update is called once per frame
    void Update()
    {

        if (canShoot == true && GameControl.instance.lose == false)
        {
            PowerUpGeneretors(powerUp, spawnPoints, randomNumberPowerUp);
        }


    }

    IEnumerator PowerUp()
    {
        // Debug.Log("Entro a la corrutina");
        yield return new WaitForSeconds(spawnTimer);
        randomNumberPowerUp = Random.Range(0, 3);
        canShoot = true;
    }



    private void PowerUpGeneretors(GameObject powerUp, GameObject[] spawnPoints, int randomNumberPowerUp)
    {
        GameObject go = (GameObject)Instantiate(powerUp, spawnPoints[randomNumberPowerUp].transform.position, spawnPoints[randomNumberPowerUp].transform.rotation);
        go.transform.Rotate(0, 0, 180);
        go.GetComponent<Rigidbody2D>().AddForce(transform.up * .2f, ForceMode2D.Impulse);
        canShoot = false;
        StartCoroutine(PowerUp());
    }


}
