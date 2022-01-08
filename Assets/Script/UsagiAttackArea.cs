using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiAttackArea : MonoBehaviour
{
    public static bool isHitAttackArea ;
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
            isHitAttackArea = true;
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isHitAttackArea = false;
        }
    }
}

