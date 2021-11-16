using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCollide2 : MonoBehaviour
{
    Rigidbody2D rb;
    bool laserOn = false;

    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (laserOn == true)
            {
                laserOn = false;

            }
            else
            {
                laserOn = true ;

            }
        }

        if (laserOn == true)
        {
            GetComponent<BoxCollider2D>().size = new Vector2(3, 78);

        }
        else
        {
            GetComponent<BoxCollider2D>().size = new Vector2(0, 0);

        }

    }
}
