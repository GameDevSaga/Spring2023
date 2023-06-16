using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTimer = 2;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(enemy, transform.position, transform.rotation);
        Invoke("Spawn", 2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Spawn()
    {
        Instantiate(enemy, transform.position, transform.rotation);
        spawnTimer = Random.Range(3, 12);
        Invoke("Spawn", spawnTimer);
    }
}
