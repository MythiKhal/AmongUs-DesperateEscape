using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController2 : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movement;
    public float speed;
    public float rotationSpeed;
    float direction;
    float gravitationalSpeed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(0, Input.GetAxisRaw("Vertical"));

        if (Input.GetKey(KeyCode.A))
        {
            direction = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = -1;
        }
        else
        {
            direction = 0;
        }
    }

    void FixedUpdate()
    {
        MoveShip(movement);
        rb.AddForce((Vector2.zero - (Vector2)transform.position) * gravitationalSpeed);
    }

    void MoveShip(Vector2 vel)
    {
        rb.AddRelativeForce(vel * speed);
        rb.AddTorque(direction * rotationSpeed);
    }

}
