using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Impact;
    public Image healthBar;
    public float healthAmount = 1000;
    public float damageNumber = 5;
    public AudioSource line100;
    public AudioSource line50;
    public AudioSource line20;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 13)
        {
            Instantiate(Impact, transform.position, Quaternion.identity);
        }
        else
        {
            TakeDamage(damageNumber);
            Instantiate(Impact, transform.position, Quaternion.identity);
        }
    }

    public void Update()
    {
        if (healthAmount == 990)
        {
            line100.Play();
        }
        else if (healthAmount == 500)
        {
            line50.Play();
        }
        else if (healthAmount == 200)
        {
            line20.Play();
        }
        else if (healthAmount <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
        healthBar.fillAmount = healthAmount / 1000;
    }

}
