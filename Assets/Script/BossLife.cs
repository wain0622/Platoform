using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLife : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    public int bossLife;
    public Animator uAnim;
    // Start is called before the first frame update
    void Start()
    {
        bossLife = 200;
        audioSource = GetComponent<AudioSource>();
        uAnim.SetBool("Death", false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Beam")
        {
            bossLife -= 75;
            audioSource.PlayOneShot(sound1);

            if (bossLife <= 0)
            {
                uAnim.SetBool("Death", true);
            }
            
        }
    } 
}
