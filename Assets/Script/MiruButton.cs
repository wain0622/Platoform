using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiruButton : MonoBehaviour
{
    public ExplanationScript explanationScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        explanationScript.miruButton.SetActive(false);
        explanationScript.minaiButton.SetActive(false);
        explanationScript.sentakuText.SetActive(false);
        explanationScript.setsumei.SetActive(true);
    }
}
