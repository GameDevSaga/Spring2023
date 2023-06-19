using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFieldScript : MonoBehaviour
{
    public GameObject spawner;

    private void Start()
    {
        
    }

    private void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Robot")
        {
             spawner.SetActive(true);
        }
    }

 /*   private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Robot")
        {
            spawner.SetActive(false);
        }
    }
 */
}
