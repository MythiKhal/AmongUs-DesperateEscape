using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movement;

    float gravitationalSpeed = 0.05f;

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
