using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearEffect : MonoBehaviour
{
    public GameObject clearCamera;
    public BossLife bossLife;
    public GameObject pCamera;
    public GameObject brige;
    // Start is called before the first frame update
    void Start()
    {
        pCamera.SetActive(true);
        clearCamera.SetActive(false);
        brige.SetActive(false);
        StartCoroutine(Brigelide());
    }

    // Update is called once per frame
    void Update()
    {
     
      
    }

    IEnumerator Brigelide()
    {
        yield return new WaitUntil(() => bossLife.dathFlag == true);
        pCamera.SetActive(false);
        clearCamera.SetActive(true);
        brige.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        pCamera.SetActive(true);
        clearCamera.SetActive(false);
    }
}
