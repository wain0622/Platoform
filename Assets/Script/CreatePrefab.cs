using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CreatePrefab : MonoBehaviour
{
    // プレハブ格納用
    public GameObject tamaPrefab;
    public float tamaSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //1秒後に呼び出され、2秒ごとに呼び出される
        InvokeRepeating("Shot", 1, 5);

    }

    // Update is called once per frame
    void Update()
    {
        
    
    }

    void Shot()
    {
        GameObject tama = Instantiate(tamaPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
        Rigidbody tamarb = tama.GetComponent<Rigidbody>();
        tamarb.AddForce(transform.forward * tamaSpeed);
        Destroy(tama, 5.0f);
    }
}