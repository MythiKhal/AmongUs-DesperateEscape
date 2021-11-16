using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Impact;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collission)
    {
        Instantiate(Impact, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
