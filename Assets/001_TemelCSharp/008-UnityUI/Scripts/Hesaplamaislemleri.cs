using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hesaplamaislemleri : MonoBehaviour
{
    [SerializeField] InputField _birinciSayiInput, _ikinciSayiInput, _ucuncuSayiInput;
    int _sayi1, _sayi2, _sayi3;
    [SerializeField] Text _sonucText;
    [SerializeField] Image _Image1 ,_Image2,_Image3;

    public void RanbomSayiBelirle1()
    {
         _sayi1 = Random.Range(1, 1000);
        

        _birinciSayiInput.text = _sayi1.ToString();
        
    }

    public void RanbomSayiBelirle2()
    {
        
         _sayi2 = Random.Range(1, 1000);
        

        
        _ikinciSayiInput.text = _sayi2.ToString();
        
    }

    public void RanbomSayiBelirle3()
    {
        
         _sayi3 = Random.Range(1, 1000);

       
        _ucuncuSayiInput.text = _sayi3.ToString();

       
    }





    public void ToplamaYap()
    {
        int _sonuc = _sayi1 + _sayi2 + _sayi3;
        _sonucText.text = ($"Toplam: {_sonuc}");

        if (_sonuc < 1500)
        {
            _Image1.color = Color.blue;
            _Image2.color = Color.blue;
            _Image3.color = Color.blue;
        }
        else
        {
            _Image1.color = Color.red;
            _Image2.color = Color.red;
            _Image3.color = Color.red;
        }

    }




}
