using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterScript : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPostition = new Vector3(target.position.x,
                                       transform.position.y,
                                       target.position.z);
        transform.LookAt(targetPostition);
        //transform.LookAt(target); // Can you make this track only .x and .z
    }
}