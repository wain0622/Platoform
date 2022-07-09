using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject particle;
    public BossLife bossLife;
    // Start is called before the first frame update
    void Start()
    {
        particle.SetActive(false);
        StartCoroutine(StartParticle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartParticle()
    {
        yield return new WaitUntil(() => bossLife.dathFlag == true);
        particle.SetActive(true);
        yield return new WaitForSeconds(6.5f);
        particle.SetActive(false);
             
    }
}
