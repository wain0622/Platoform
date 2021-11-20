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
    public int score;
    public Text scoreText;
    public GameObject pleyer;
    public static int life = 5;
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
                rb.AddForce(0, 5, 0,ForceMode.Impulse);
                isGround = false;
            }
        }

        if (transform.position.y < -18)
        {
            SceneManager.LoadScene("GameOverScene");
            life--;
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

    private void OnCollisionEnter(Collision collision)//ここからタグを使った当たり判定のプログラム
    {
      if (collision.gameObject.tag == "Ground")
        {

            isGround = true;
        }

      if (collision.gameObject.tag == "Mmikamaru")
        {
            SceneManager.LoadScene("GameOverScene");
            life--;
            
        }



        if (collision.gameObject.tag == "HitPoint")
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }

        if (collision.gameObject.tag == "Dead")
        {
            SceneManager.LoadScene("GameOverScene");
            life--;
        }

        if (collision.gameObject.tag == "Warp")
        {
            StartCoroutine(GameOver());
        }

        if (collision.gameObject.tag == "Flag")
        {
            SceneManager.LoadScene("Success");

        }
    }
    IEnumerator GameOver()
    {
        transform.position = new Vector3(0, -16, 0);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("GameOverScene");
        life--;
    }

} 
