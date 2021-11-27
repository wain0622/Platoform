using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ugokizimen : MonoBehaviour
{
    public float speed = 0.1f;
    public int direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -13)
        {
            direction = -1;
        }
        else if (transform.position.x <= -18)
        {
            direction = 1;
        }

        transform.position += new Vector3 (speed*direction, 0, 0);


    }

}
