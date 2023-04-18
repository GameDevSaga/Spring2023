using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [Header("Shooting")]
    public Transform gun;
    public GameObject bullet;
    public float fireRate = 2f;
    public bool canFire = true;

    [Header("Player Movement")]
    [Range(0.1f, 30f)] // creates a handy min and max value slider for player speed
    public float playerSpeed = 10f;
    public float hor;
    public float ver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hor * playerSpeed * Time.deltaTime, 0, ver * playerSpeed * Time.deltaTime));
        //transform.position = Vector3.Lerp(transform.position, hit.point, 0.1f); stole this from another script, the lerp does the delay (from where, to where, at what speed)

        //This is for shooting
        if (Input.GetButton("Fire1") && canFire)
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
