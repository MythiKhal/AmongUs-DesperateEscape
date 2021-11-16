using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthEnemy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Impact;
    public Image healthBar;
    public float healthAmount = 1000;
    public float timer;
    public float damageNumber = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D collission)
    {
        TakeDamage(damageNumber);
        Instantiate(Impact, transform.position, Quaternion.identity);
    }

    public void Update()
    {
        if (healthAmount <= 0)
        {
            SceneManager.LoadScene("Ending");
        }

    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
        healthBar.fillAmount = healthAmount / 1000;
        
        
    }

}
