using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawnerScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Robot")
        {
            Destroy(gameObject);
        }
    }
}
