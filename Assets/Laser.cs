using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public LineRenderer lr;
    public Transform laserPosition;
    public Animator camAnim;
    public AudioSource laserbeam;

    private void Start()
    {
        lr.enabled = false;
        
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
        lr.SetPosition(0, laserPosition.position);
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(lr.isVisible == true)
            {
                lr.enabled = false;
                camAnim.SetTrigger("Shake");
                laserbeam.Stop();
                
            }
            else
            {
                lr.enabled = true;
                camAnim.SetTrigger("Shake");
                laserbeam.Play();
                
            }
        }

        if (hit) {

            lr.SetPosition(1, hit.point);


        }
        else
        {
            lr.SetPosition(1, transform.right * 200);

        }
    }
   
}
