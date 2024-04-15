using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechAmmoScript : MonoBehaviour
{
    public float speed = 5f;
    public HealthManager hm;

    // Start is called before the first frame update
    void Start()
    {
        hm = GameObject.Find("HealthManager").GetComponent<HealthManager>();
        Destroy(gameObject, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
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
