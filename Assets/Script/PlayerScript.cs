using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void FixedUpdate()
    {
        var hori= Input.GetAxisRaw("Horizontal");
        var moveVector = new Vector3(hori, 0, 0);
        rb.velocity += moveVector*speed;
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = Vector3.zero ;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = Vector3.zero;
        }
    }
} 
