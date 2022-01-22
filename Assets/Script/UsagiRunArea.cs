using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiRunArea : MonoBehaviour
{
    public static bool isRunArea;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isRunArea = true;
            Debug.Log("true");
          
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
