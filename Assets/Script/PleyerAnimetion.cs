﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerAnimetion : MonoBehaviour
{
    public Animator anim;
    static public int canonPrepare;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("isRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("isRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("jump", true);
        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("jump", false);
        }
    }

    public void Death()
    {
        anim.SetBool("Death", true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "prepare")
        {
            anim.SetBool("isPrepare", true);
            canonPrepare = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "prepare")
        {
            anim.SetBool("isPrepare", false);
            canonPrepare = 0;
        }
    }
}
