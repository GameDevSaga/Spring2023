using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechnologistScript : MonoBehaviour
{
    public Transform target;
    public float enemySpeed = 5f;
    //public GameObject loseMenu;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        //loseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
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
            Destroy(other.gameObject);
            /*loseMenu.SetActive(true);
            Time.timeScale = 0f;*/
            Destroy(gameObject);
        }
    }
}
