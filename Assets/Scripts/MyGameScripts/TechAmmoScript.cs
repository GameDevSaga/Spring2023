using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechAmmoScript : MonoBehaviour
{
    public float speed = 5f;
    public HealthManager hm;
    //public GameObject loseMenu;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 20f);
        //loseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
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
            StartCoroutine(HitStop());
            //Destroy(other.gameObject);
            /*loseMenu.SetActive(true);
            Time.timeScale = 0f;*/
        }
    }

    public IEnumerator HitStop()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(0.3f);
        Time.timeScale = 1f;
        Destroy(gameObject);
    }
}
