using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHpScript : MonoBehaviour
{
    private Slider setSlider;//Sliderを使用するための変数
    public GameObject slider;//実際に使用するHPゲージ
    [SerializeField]
    public static int HP = 100;// 体力　※Sliderで設定したMaxValueの値と揃えましょうv
    // Start is called before the first frame update
    void Start()
    {
        setSlider = slider.GetComponent<Slider>();// sliderの値をHPゲージの値にする
    }

    // Update is called once per frame
    void Update()
    {
        setSlider.value = HP;//slider.valueを体力にする

        if(HP <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
