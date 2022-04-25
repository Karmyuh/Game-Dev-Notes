using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoroutineOrnek : MonoBehaviour
{

    [SerializeField] SpriteRenderer _kirmizi, _sari, _yesil;
    [SerializeField] Text _info;

    void Start()
    {
        StartCoroutine(TrafikLamba());

    }
    void Update()
    {
        
    }
    void Kirmizi()
    {
        _kirmizi.color = Color.red;
        _info.color = Color.red;
        _info.text = "DUR";
    }
    void Sari()
    {
        _sari.color = Color.yellow;
        _info.color = Color.yellow;
        _info.text = "HAZIRLAN";
    }
    void Yesil()
    {
        _yesil.color = Color.green;
        _info.color = Color.green;
        _info.text = "GEC";
    }
    
    IEnumerator TrafikLamba() 
    {
        yield return new WaitForSeconds(1);
        Kirmizi();
        yield return new WaitForSeconds(1);
        _kirmizi.color = Color.black;
        yield return new WaitForSeconds(1);
        Sari();
        yield return new WaitForSeconds(1);
        _sari.color = Color.black;
        yield return new WaitForSeconds(1);
        Yesil();
    }
}
