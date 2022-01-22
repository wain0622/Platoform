using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeattacked : MonoBehaviour
{
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
        if (other.gameObject.tag == "BosUsagi")
        {
            PlayerHpScript.HP -= 20;
        }


        if(other.gameObject.tag == "Dead")
        {
            PlayerHpScript.HP -= 10;
        }
    }
}
