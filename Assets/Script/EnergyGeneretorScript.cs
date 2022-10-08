using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnergyGeneretorScript : MonoBehaviour
{
    public int energys;
    public GameObject energy;
    private Vector3 energyPos;
    public int energyQuantity;
    public PlayerScript playerScript;
    public Text energyText;
    // Start is called before the first frame update
    void Start()
    {
        energyPos = this.transform.position;
        energyQuantity = 10;//ビーム1回打つのに必要な数(プレイヤースクリプトで使用しているから消しちゃダメ)
        for(int i= 0; i < 3; i++)
        {
            energyPos.x = Random.Range(-28, 4);
            Instantiate(energy, energyPos, Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {
        energys = GameObject.FindGameObjectsWithTag("Energy").Length;

        if (energys <= 2 && playerScript.getEnergy <= 7)
        {
            energyPos.x = Random.Range(-28, 4);
            Instantiate(energy, energyPos, Quaternion.identity);
        }

        energyText.text = "残りエナジー数:" + energyQuantity.ToString() + "エナジーを10個集めてレーザーを撃とう!";

        if (energyQuantity == 0)
        {
            energyText.text = "残りエナジー数:" + energyQuantity.ToString() + "エナジーが10個集まったからレーザーが撃てるよ";
        }

    }
}