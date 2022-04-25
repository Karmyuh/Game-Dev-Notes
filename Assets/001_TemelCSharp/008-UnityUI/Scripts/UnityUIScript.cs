using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityUIScript : MonoBehaviour
{
    [SerializeField] InputField _birinciSayiInput, _ikinciSayiInput;
    int _sayi1, _sayi2;
    [SerializeField] Text _sonucText;
    [SerializeField] Image _Image1, _Image2, _Image3;

    public void RanbomSayiBelirle1()
    {
        _sayi1 = Random.Range(1, 1000);
        _sayi2 = Random.Range(1, 1000);

        _ikinciSayiInput.text = _sayi2.ToString();
        _birinciSayiInput.text = _sayi1.ToString();
    }
    public void ToplamaYap()
    {
        int _sonuc = _sayi1 + _sayi2 ;
        _sonucText.text = ($"Topladın: {_sonuc}");
        if (_sonuc < 1500)
        {
            _Image1.color = Color.yellow;   
        }
        else
        {
            _Image1.color = Color.red;
        }
    }
    public void CıkartmaYap()
    {
        int _sonuc = _sayi1 - _sayi2;
        _sonucText.text = ($"Çıkarttın: {_sonuc}");
        if (_sonuc < 1500)
        {
            _Image1.color = Color.yellow;
        }
        else
        {
            _Image1.color = Color.red;
        }
    }
    public void CarpmaYap()
    {
        int _sonuc = _sayi1 * _sayi2;
        _sonucText.text = ($"Çarptın: {_sonuc}");
        if (_sonuc < 1500)
        {
            _Image1.color = Color.yellow;
        }
        else
        {
            _Image1.color = Color.red;
        }
    }
}