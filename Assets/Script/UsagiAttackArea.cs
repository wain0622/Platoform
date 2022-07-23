using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiAttackArea : MonoBehaviour
{
    public bool isHitAttackArea ;
    public UsagiRunArea usagiRunArea;
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
            usagiRunArea.isRunArea = false;
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

