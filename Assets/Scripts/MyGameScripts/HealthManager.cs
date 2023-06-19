using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;
    public GameManager gm;

    public TextMeshProUGUI hpText;
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        //hpText.text = "HP " + healthAmount.ToString() + "/100";
        gm = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            // Application.LoadLevel(Application.loadedLevel); outdated?
            //print("Game Over");
            StartCoroutine(HitStop());

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            TakeDamage(20);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Heal(10);
        }
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);
        healthBar.fillAmount = healthAmount / 100f;
        hpText.text = "HP " + healthAmount.ToString() + "/100";
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);
        healthBar.fillAmount = healthAmount / 100f;
        hpText.text = "HP " + healthAmount.ToString() + "/100";
    }

    public IEnumerator HitStop()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1f;

        gm.KillPlayer();
    }

}
