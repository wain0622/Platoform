using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HartGeneretorScript : MonoBehaviour
{
    public GameObject hart;
    public PlyaerHP plyaerHP;
    public Vector3 hartPos;
    // Start is called before the first frame update
    void Start()
    {
        hartPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
     if (plyaerHP.pHP<= 30)
        {
            hartPos.x = Random.Range(-28, 4);
            Instantiate(hart,hartPos,Quaternion.identity);
        }

        else
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Hart");
            foreach (GameObject hart in objects)
            {
                Destroy(hart);
            }

        }
    }

    
}
