using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplanationScript : MonoBehaviour
{
    public GameObject blackPanel;
    public GameObject setsumei;
    public GameObject miruButton;
    public GameObject minaiButton;
    public GameObject sentakuText;
    // Start is called before the first frame update
    void Start()
    {
        setsumei.SetActive(false);
        blackPanel.SetActive(true);
        miruButton.SetActive(true);
        minaiButton.SetActive(true);
        sentakuText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
