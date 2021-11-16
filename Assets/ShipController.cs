using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movement;
    public float speed;
    public float rotationSpeed;
    float direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

       
    }

    void FixedUpdate()
    {
        MoveShip(movement);
    
    }

    void MoveShip(Vector2 vel)
    {
        rb.AddRelativeForce(vel * speed);
        rb.AddTorque(direction * rotationSpeed);
    }

}
