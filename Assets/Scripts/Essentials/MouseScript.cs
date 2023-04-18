using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{

    public LayerMask layerMask;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // fixedupdate repeats on a time based cycle, not dependent on frames
        Ray myray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(myray, out hit, Mathf.Infinity,layerMask))
        {
            transform.position = Vector3.Lerp(transform.position, hit.point,0.1f); //moves object following mouse location

            /*if(Input.GetButtonDown("Fire1") && hit.transform.CompareTag("Enemy"))
            {
                Destroy(hit.transform.gameObject);
            }
            */
        }

        //Debug.DrawRay(Camera.main.transform.position, Vector3.forward, Color.green, 1000f);
    }
}
