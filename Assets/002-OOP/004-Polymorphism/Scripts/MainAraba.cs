using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAraba : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       ArabaOlustur();
    }


    void ArabaOlustur()
    {

        Bmw _bmw1 = new Bmw();
        _bmw1.Marka = "BMW";
        _bmw1.Model = "BMW Model";
        _bmw1.SifirMi = true;
        _bmw1.Hiz = 250f;
        _bmw1.KapiSayisi = 2;
        _bmw1.Fiyati = 50000m;


        _bmw1.SatisYap();
        Debug.Log("BMW Fiyatı: " + _bmw1.ToplamFiyati);


        Mercedes _mercedes1 = new Mercedes();
        _mercedes1.Marka = "Mercedes";
        _mercedes1.Model = "Mercedes Model";
        _mercedes1.SifirMi = true;
        _mercedes1.Hiz = 250f;
        _mercedes1.KapiSayisi = 2;
        _mercedes1.Fiyati = 50000m;


       _mercedes1.SatisYap();

        Debug.Log("Mercedes Fiyatı: " + _mercedes1.ToplamFiyati);


        Ferrari _fer = new Ferrari();
        _fer.Marka = "Mercedes";
        _fer.Model = "Mercedes Model";
        _fer.SifirMi = true;
        _fer.Hiz = 250f;
        _fer.KapiSayisi = 2;
        _fer.Fiyati = 50000m;


        _fer.SatisYap();

        Debug.Log("Ferrari Fiyatı: " + _fer.ToplamFiyati);

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
