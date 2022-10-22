using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlyaerHP : MonoBehaviour
{
    public int pHP = 100;
    public GameObject gameOver;
    public UsagiAttackArea usagiAttack;
    public BossLife bossLife;
    public GameObject hart;
    public Text pHPText;
    public GameObject redEffect;
    // Start is called before the first frame update
    void Start()
    {
        redEffect.SetActive(false);
        StartCoroutine(BossAttack());
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (bossLife.dathFlag)
        {
            this.enabled = false;
        }

        pHPText.text = "HP:" + pHP;

        if (pHP <= 20)
        {
            pHPText.color = new Color(1.0f, 0.0f, 0.0f);
            pHPText.text = "HP:" + pHP.ToString();
            redEffect.SetActive(true);
        }
        else
        {
            pHPText.color = new Color(0.0f, 0.0f, 0.0f);
            redEffect.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hart")
        {
            pHP =pHP + 20;
            Destroy(collision.gameObject);

            
        }
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
                    redEffect.SetActive(false);
                }
                yield return new WaitForSeconds(1.5f);
               
            }
        }

    }
  
}
