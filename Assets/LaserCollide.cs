using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCollide : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject Impact;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Physics.IgnoreLayerCollision(12, 9);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 9)
        {
            Instantiate(Impact, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (collision.gameObject.layer == 11)
        {
            Instantiate(Impact, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
