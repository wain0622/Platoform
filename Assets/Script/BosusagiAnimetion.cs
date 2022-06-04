using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosusagiAnimetion : MonoBehaviour
{
    public　static Animator anim;
    public UsagiRunArea runArea;
    public BossLife bossLife;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      if (UsagiAttackArea.isHitAttackArea)
        {
            anim.SetBool("Slash", true);
        }
        else
        {
            anim.SetBool("Slash", true);
        }
      if (runArea.isRunArea)
        {
            anim.SetBool("Run", true);
            
        }
        else
        {
            anim.SetBool("Run", false);
            
        }

      if (bossLife.dathFlag)
        {
            anim.SetBool("Slash",false);
            anim.SetBool("Run", false);
        }
    }

    
}
