using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyGeneretorScript : MonoBehaviour
{
    public GameObject energy;
    private Vector3 energyPos;
    public int energyQuantity;
    // Start is called before the first frame update
    void Start()
    {
        energyPos = this.transform.position;
        energyQuantity = 10;
        for(int i= 0; i < 3; i++)
        {
            energyPos.x = Random.Range(-28, 4);
            Instantiate(energy, energyPos, Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {
      
    }
}
