using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLife : MonoBehaviour
{
    public int bossLife;
    // Start is called before the first frame update
    void Start()
    {
        bossLife = 200;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Beam")
        {
            bossLife -= 75;

        }
    }
}
