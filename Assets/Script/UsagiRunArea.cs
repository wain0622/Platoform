using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiRunArea : MonoBehaviour
{
    public bool isRunArea;
    public float diff;
    public GameObject usagi;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (diff <= 0)
        {
            usagi.transform.rotation = Quaternion.Euler(0.0f, -90, 0.0f);
             
        }
        else
        {
            usagi.transform.rotation = Quaternion.Euler(0.0f, 90, 0.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isRunArea = true;
            diff = other.transform.position.x - this.transform.position.x; 
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isRunArea = false;
            
        }
    }

}
