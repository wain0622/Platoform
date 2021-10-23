using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool isGround;
    public int Score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        isGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(0, 10, 0,ForceMode.Impulse);
                isGround = false;
            }
        }
        ScoreText.text = "Score:" + Score;

        if (transform.position.y < -18)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    private void FixedUpdate()
    {
        var hori= Input.GetAxisRaw("Horizontal");
        var moveVector = new Vector3(hori, 0, 0);
        rb.velocity += moveVector*speed;
    
       

        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = Vector3.zero;
        }

       
    }

    private void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.tag == "Ground")
        {

            isGround = true;
        }

      if (collision.gameObject.tag == "Mmikamaru")
        {
            Debug.Log("ゲームオーバー");
        }



        if (collision.gameObject.tag == "HitPoint")
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }

        if (collision.gameObject.tag == "Flag")
        {
            SceneManager.LoadScene("Success");

        }
    }


} 
