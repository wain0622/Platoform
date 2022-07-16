using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyaerHP : MonoBehaviour
{
    public int pHP = 100;
    public GameObject gameOver;
    public UsagiAttackArea usagiAttack;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BossAttack());
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator  BossAttack()
    {
        while (true)
        {
            yield return null;
            while (usagiAttack.isHitAttackArea == true)
            {   
                pHP -= 20;
                if (pHP == 0)
                {
                    gameOver.SetActive(true);
                }
                yield return new WaitForSeconds(1.5f);
               
            }
        }

    }
  
}
