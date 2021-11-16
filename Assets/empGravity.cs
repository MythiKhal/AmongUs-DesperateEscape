using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empGravity : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movement;

    float gravitationalSpeed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        rb.AddForce((Vector2.zero - (Vector2)transform.position) * gravitationalSpeed);
    }


}
