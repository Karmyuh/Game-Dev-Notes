using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Using : Kutuphane

public sealed class Degiskenler0011 : MonoBehaviour
{
    // -----------------Unity Fonksiyonlar ve Degiskenler------------------- ^.$\n
    // AYVANSARAY UNI. DERS NOTLARI - OGRETMEN: D. DAVUT ASKAR
    // https://docs.unity3d.com/Manual/ExecutionOrder.html

    public int _sayi1 = 10; // basinda bir sey yoksa private degiskendir.
    public float _sayi2 = 20.5f; // Public, global degiskendir.
    private string text = "Merhaba";
    private bool _aktifMi = false;

    protected int _Sayi11 = 1;
    protected internal int _sayi33;

    //Degisken belirleme kurallari

    //Degisken isimleri benzersiz olmalidir. Buyuk kucuk harf duyarlidir ve sayi ile baslayamaz.
    //Degiskenler belirlenirken "camelCase" yontemi kullanilir. Orn; int carCount = arabaSinifi;
    //Degiskeni deklare ettikten sonra noktali virgul kullanilmalidir.

    private void Awake()
    {
        //  Debug.Log("Awake Calisti.");
        //Script dosyasi companenti pasif olsa bile calisir. Start ile arasindaki en buyuk fark budur.
    }

    private void Start()
    {
        Debug.Log("Start Calisti.");
        //Start fonksiyonu Awake fonksiyonundan sonra calisan fonksiyondur. Start fonksiyonunun calismasi icin bulundugu objenin aktif olmasi gerekir. Obje aktif degilse sadece Awake fonksiyonu calisir Start fonksiyonu calismaz.
        Interpolation();
    }

    private void Update()
    {
        //Debug.Log("Duzenli bir sekilde calismaz. Her frame'de calisir. PC'nin hizina bagli olarak degisIklik gosterir.");
        //Update fonksiyonu bir kere calisip durmaz, her frame de calisir. Yani ne demek bu bilgisayariniz 60 frame ise Update fonksiyonu saniyede 60 kere calismis oluyor. Bilgisayarin donanimina gore de calisma sayisi degisIklik gosterir. Daha iyi bilgisayarlarda Update fonksiyonu saniyede 100 kere de calisabilir. Ve onemli bir bilgi olarak da calisma araliklari ayni degildir.
    }

    private void FixedUpdate()
    {
        // Debug.Log("Duzenli bir sekilde belirli araliklarla calistigi icin Fizik olaylarinda kullanilir. Her 0,02 saniyede calisir. Bu aralik degistirilebilir");
        //FixedUpdate fonksiyonu duzenli bir bicimde her zaman calisir. Update fonsiyonundan farki duzenli bir sekilde calismasidir. Genelde 0.02 saniyede bir calisir. Donanimdan donanima bu sure degismez. Duzenli calistigi icin fizik olaylarinda kullanilir. Fizik olaylarinda normal Update fonksiyonu kullanilmamasi gerekir. Cunku duzenli bir sekilde calismadigi icin saglikli olmaz.
        //Ornegin; topun, havadan dusus suresi...
    }

    private void LateUpdate()
    {
        //  Debug.Log("En son calisan Update fonksiyonu. Genellikle oyuncu kamerasi icin kullanilir.");
        //LateUpdate fonksiyonu genel olarak en son calisan update fonksiyonudur. En son kare gibi dusunebiliriz bunu ama mantigina baktigimiz zaman aslinda Update, FixedUpdate gibi fonksiyonlardaki islemler yapildiktan ve bittikten sonra calisan Update fonksiyondur. Tum islemler bittikten sonra kullanilir.
        //Ornegin ThirdPerson Camera. Cevre yuklenmesi biter ve sonra kamera cagrilir.
    }

    private void Interpolation()
    {
        //Peki bir metinin icine degisken yazabilir miyiz? Evet yazabiliriz buna string "interpolation" denir. Bunun icin metnin basina dolar sembolu kullanilir.
        int _sayiDonusum = (int)_sayi2;

        Debug.Log($"Sayi {_sayiDonusum}");
    }
}