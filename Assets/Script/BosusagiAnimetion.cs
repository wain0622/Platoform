﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosusagiAnimetion : MonoBehaviour
{
    private Animator anim;
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
            anim.SetBool("Slash", false);
        }
      if (UsagiRunArea.isRunArea)
        {
            anim.SetBool("Run", true);
            
        }
        else
        {
            anim.SetBool("Run", false);
            
        }
    }

    
}