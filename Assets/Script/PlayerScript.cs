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
    public GameObject gameOverPanel;
    public PleyerAnimetion pleyerAnimetion;
    public GameObject warpShutter;
    static public int warp_1;
    public float countUp = 0.0f;
    public bool isWarp;
    public float timeLimit = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        isGround = false;
        gameOverPanel.SetActive(false);
        warpShutter.SetActive(false);
        isWarp = false;
      
    }
    // Update is called once per frame
    void Update()
    {
        if (isWarp)
        {
            countUp += Time.deltaTime;
        }

        if(countUp >= timeLimit)
        {
            SceneManager.LoadScene("Stege1");
        }

        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {   
                rb.AddForce(0, 5, 0, ForceMode.Impulse);
                isGround = false;
            }
        }
    }

    private void FixedUpdate()
    {
        var hori = Input.GetAxisRaw("Horizontal");
        var moveVector = new Vector3(hori, 0, 0);
        rb.velocity += moveVector * speed;



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

        if (collision.gameObject.tag == "HitPoint")
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }

        if (collision.gameObject.tag == "Dead")
        {
            pleyerAnimetion.Death();
            gameOverPanel.SetActive(true);
            life--;
        }

        if (collision.gameObject.tag == "Warp")
        {
            isWarp = true;
            warpShutter.SetActive(true);
            warp_1 = 1;
           
        }

        if (collision.gameObject.tag == "Flag")
        {
            ScoreText.score += 10;
            SceneManager.LoadScene("Success");

        }

        if (collision.gameObject.tag == "coin")
        {
            ScoreText.score++; 
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
