using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyaerHP : MonoBehaviour
{
    public int pHP = 100;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "UsagiAttack")
        {
            pHP -= 20;

            if (pHP <= 0)
            {
                gameOver.SetActive(true);
            }
        }

    }
}
