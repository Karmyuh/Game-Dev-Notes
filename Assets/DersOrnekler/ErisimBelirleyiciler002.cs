using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErisimBelirleyiciler002 : MonoBehaviour
{

    // ----------------C# Erisim Belirleyiciler (Access Modifiers)------------------- ^.$\n
    // AYVANSARAY UNI. DERS NOTLARI - OGRETMEN: D. DAVUT ASKAR

    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

    //private
    //Gizli olan degerleri tanimlamak icin kullandigimiz erisim belirleyicisidir ve sadece kendi sinifindan(class) erisilebilir olmasini saglar atandigi degere.
    //Yazdiginiz kodda kesinlikle degistirilmemesi gereken degerler/degiskenler icin kullanabilirsiniz.

    //public
    //Degerlere diger siniflardan da erisilebilmesini ve duzenlenebilmesini saglayan belirleyicidir ve hic bir kisitlama icermez.

    //Protected
    //Atadiginiz degeri korumali yapan erisim belirleyicisidir, sadece ayni siniftan tureyen siniflar tarafindan erisilebilir.

    //Internal
    //Ayni program icerisinden erisilebilir ancak baska bir program tarafindan erisilemez degerlerdir.

    //Protected Internal
    //Protected internal olarak tanimlanmis deger, tanimlandigi sinifin icinden ve ondan turetilen siniflarin icinden erisilebilir durumdadir. Turetilen sinifin ayni program icinde olmamasi sorun teskil etmez.




    //Editor Erisim Belirleyicileri

    //SerializeField
    //Public olsun olmasin tanimladigimiz tum degiskenlerimizin editorde Inspector penceresinde gorunmesini saglar.

    //HideInInspector
    //public olarak ayarlanmis veya SerializeField ile editorde gorunur yapilmis degiskenlerin, editorde gizlenmesini saglar.


    void Start()
    {




    }


    void Update()
    {

    }
}
