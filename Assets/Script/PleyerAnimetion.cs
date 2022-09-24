 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerAnimetion : MonoBehaviour
{
    public Animator anim;
    static public int canonPrepare;
    public GameObject beam;
    public Camera cameraComponent;
    public PlayerScript ps;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        cameraComponent.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("isRunning", true);
            transform.localEulerAngles = new Vector3(0, -90, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("isRunning", true);
            transform.localEulerAngles = new Vector3(0, 90, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("jump", true);
        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("jump", false);

        }
    }

    public void Death()
    {
        anim.SetBool("Death", true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "prepare" && ps.getEnergy == 10)
        {
            anim.SetBool("isPrepare", true);
            StartCoroutine(AttackEffect());
            canonPrepare = 1;
            beam.SetActive(true);
            cameraComponent.enabled = true;
                           
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "prepare")
        {
            anim.SetBool("isPrepare", false);
            canonPrepare = 0;
            beam.SetActive(false);
            cameraComponent.enabled = false;
        }
    }

    IEnumerator AttackEffect()
    {

        ps.enabled = false;
        yield return new WaitForSeconds(4.5f);
        ps.enabled = true;
    }
}
