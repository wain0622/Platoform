using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool isGround; 
    // Start is called before the first frame update
    void Start()
    {
        isGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(0, 10, 0,ForceMode.Impulse);
                isGround = false;
            }
        }

    }

    private void FixedUpdate()
    {
        var hori= Input.GetAxisRaw("Horizontal");
        var moveVector = new Vector3(hori, 0, 0);
        rb.velocity += moveVector*speed;
    
       

        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = Vector3.zero;
        }

       
    }

    private void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.tag == "Ground")
        {

            isGround = true;
        }
    }


} 
