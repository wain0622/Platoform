using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBeamScript : MonoBehaviour
{
    public GameObject Beam;
    public PlayerScript pS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PleyerAnimetion.canonPrepare == 1)
        {
            Instantiate(Beam, transform.position, Quaternion.identity);
            pS.getEnergy = 0;
        }
    }
}
