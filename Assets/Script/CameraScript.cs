using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float posx = Player.transform.position.x;
        float posy = Player.transform.position.y;
        float posz = Player.transform.position.z;

        transform.position = new Vector3(posx, posy + 2, posz + 16);
    }
}
