using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechnologistScript : MonoBehaviour
{
    public Transform target;
    public float enemySpeed = 5f;
    public HealthManager hm;

    // Start is called before the first frame update
    void Start()
    {
        hm = GameObject.Find("HealthManager").GetComponent<HealthManager>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hm.TakeDamage(20);
            Destroy(gameObject);
        }
    }
}
