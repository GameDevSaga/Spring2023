using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Game Mode")]
    public bool twinstick = false;
    public bool classic = false;

    [Header ("Player Movement")]
    [Range(0.1f, 30f)] // creates a handy min and max value slider for player speed
    public float playerSpeed = 10f;
    public float hor;
    public float ver;

    [Header("Shooting")]
    public Transform gun;
    public GameObject bullet;
    public float fireRate = 0.5f;
    public bool canFire = true;

    // Start is called before the first frame update
    void Start()
    {
        if(twinstick)
        {
            gun.GetComponent<TwinStickAim>().enabled = true; //twinstick aim on
            gun.GetComponent<GunScript>().enabled = false; //look at target off
        }
        else if(classic) //this mode turns both aims off and just shoots straight in one direction
        {
            gun.GetComponent<TwinStickAim>().enabled = false;
            gun.GetComponent<GunScript>().enabled = false;
        }
        else
        {
            gun.GetComponent<TwinStickAim>().enabled = false; //twinstick aim off
            gun.GetComponent<GunScript>().enabled = true; //look at target on
        }
    }

    // Update is called once per frame
    void Update()
    {
        //This is for moving the player
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hor*playerSpeed*Time.deltaTime,ver*playerSpeed*Time.deltaTime,0));
        //transform.Translate(Vector3.up * playerSpeed * Time.deltaTime * ver); single axis motion

        //This is for shooting
        if(!twinstick && Input.GetButton("Fire1") && canFire)
        {
            StartCoroutine("Shoot");
        }
        
    }

    public IEnumerator Shoot()
    {
        Instantiate(bullet, gun.position, gun.rotation);
        canFire = false;
        yield return new WaitForSeconds(fireRate);
        canFire = true;
    }

}
