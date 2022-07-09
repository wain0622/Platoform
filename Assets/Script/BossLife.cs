using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLife : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    public int bossLife;
    public Animator uAnim;
    public bool dathFlag;
    public MeshRenderer swordMesh, shieldMesh;
    public SkinnedMeshRenderer bodyMesh;
    static public bool bossDestroy;

    // Start is called before the first frame update
    void Start()
    {
        dathFlag = false;
        bossLife = 200;
        audioSource = GetComponent<AudioSource>();
        uAnim.SetBool("Death", false);
        StartCoroutine(Transparent());

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
                dathFlag = true;
                uAnim.SetBool("Death", true);

            }


        }
    }
    IEnumerator Transparent()
    {
        yield return new WaitUntil(() => dathFlag == true);
        yield return new WaitForSeconds(2.0f);
        for (int i = 0; i < 64; i++)
        {
            bodyMesh.material.color = bodyMesh.material.color - new Color32(0, 0, 0, 4);
            swordMesh.material.color = swordMesh.material.color - new Color32(0, 0, 0, 4);
            shieldMesh.material.color = shieldMesh.material.color - new Color32(0, 0, 0, 4);
            yield return new WaitForSeconds(0.01f);

        }
        Destroy(gameObject);
        bossDestroy = true;
    }
}
