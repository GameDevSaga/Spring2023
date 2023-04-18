using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechTurretScript : MonoBehaviour
{

    public Transform target;
    public GameObject ammo;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("Shoot", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPostition = new Vector3(target.position.x,
                               transform.position.y,
                               target.position.z);
        transform.LookAt(targetPostition);
        //transform.LookAt(target);
    }

    public void Shoot()
    {
        Instantiate(ammo, transform.position, transform.rotation);
    }
}
