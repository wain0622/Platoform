using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DamageEffect : MonoBehaviour
{
    private static readonly int PROPERATY_COLOR = Shader.PropertyToID("_Color");
    [SerializeField]
    private Renderer _renderer;

    private Material _material;
    private Sequence _seq;

   

    private void Awake()
    {
        _material = _renderer.material;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Beam")
        {
             HitFadeBlink(Color.red);

        }
    }



    private void HitFadeBlink(Color color)
    {
        _seq?.Kill();
        _seq = DOTween.Sequence();
        _seq.Append(DOTween.To(() => Color.white, c => _material.SetColor(PROPERATY_COLOR, c), color, 1.0f));
        _seq.Append(DOTween.To(() => color, c => _material.SetColor(PROPERATY_COLOR,c), Color.white, 1.0f));
        _seq.Play();

        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
