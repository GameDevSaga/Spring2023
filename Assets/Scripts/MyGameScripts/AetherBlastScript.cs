using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AetherBlastScript : MonoBehaviour
{
    public float blastSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1.7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * blastSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
