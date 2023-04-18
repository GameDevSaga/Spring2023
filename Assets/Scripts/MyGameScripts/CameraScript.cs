using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float delay = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target);
        // transform.position = Vector3.Lerp(transform.position, target.position, delay * Time.deltaTime); old version, testing new!

        // set a target location to be target.y target.z but current on .x and then add to above instead of target.position the target location?
        Vector3 newLocation = target.position;
        newLocation.x = transform.position.x;
        transform.position = Vector3.Lerp(transform.position, newLocation, delay * Time.deltaTime);

    }
}