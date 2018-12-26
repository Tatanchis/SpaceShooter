using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

    private bool shootButtonClicked = false;
    public Button shootButton;
    public Button shootLeftButton;
    public Button shootRightButton;
    public GameObject cannonBall;
    public GameObject shootPosition;
    public GameObject shootPositionPowerUpLeft;
    public GameObject shootPositionPowerUpRight;
    public Vector2 velocity;
    bool canShoot = true;
    public Vector2 offset = new Vector2(.0f, 1f);
    public float timeToShoot = 2f;
    public float timer = 0;
    public float powerUpTimer = 0;
    //GameControl instance;

    public AudioClip shootingCannon;
    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Button btn = shootButton.GetComponent<Button>();
        btn.onClick.AddListener(ShootClick);
        Button btnLeft = shootLeftButton.GetComponent<Button>();
        btnLeft.onClick.AddListener(ShootClick);
        Button btnRight = shootButton.GetComponent<Button>();
        btnRight.onClick.AddListener(ShootClick);
        timer += Time.deltaTime;

        if (shootButtonClicked == true && canShoot == true)
        {
            if (timer > timeToShoot)
            {
                GameObject go = (GameObject)Instantiate(cannonBall, shootPosition.transform.position, shootPosition.transform.rotation);
                go.GetComponent<Rigidbody2D>().AddForce(transform.up * 2f, ForceMode2D.Impulse);

                if (GameControl.instance.powerUp == true && powerUpTimer < .07)
                {
                    GameObject go1 = (GameObject)Instantiate(cannonBall, shootPositionPowerUpRight.transform.position, shootPositionPowerUpRight.transform.rotation);
                    go1.GetComponent<Rigidbody2D>().AddForce(transform.up * 2f, ForceMode2D.Impulse);
                    GameObject go2 = (GameObject)Instantiate(cannonBall, shootPositionPowerUpLeft.transform.position, shootPositionPowerUpLeft.transform.rotation);
                    go2.GetComponent<Rigidbody2D>().AddForce(transform.up * 2f, ForceMode2D.Impulse);
                    powerUpTimer += Time.deltaTime;
                    //StartCoroutine(ShootCorrutina());
                    Debug.Log("Power up timer es " + powerUpTimer);
                }

                if(powerUpTimer > .07)
                {  
                    GameControl.instance.powerUp = false;
                    powerUpTimer = 0;
                }
                //shootButtonClicked = false;
                //canShoot = false;
                //StartCoroutine(ShootCorrutina());
                //source.PlayOneShot(shootingCannon, 1);
                timer = 0;
            }

        }


    }

    private void ShootClick()
    {
        shootButtonClicked = true;

    }

    IEnumerator ShootCorrutina()
    {
        Debug.Log("Entro a la corrutina");
        yield return new WaitForSeconds(1f);
        shootButtonClicked = false;
        canShoot = true;
    }

    IEnumerator PowerUpCorrutina()
    {
        yield return new WaitForSeconds(5f);
        GameControl.instance.powerUp = false;

    }
}
