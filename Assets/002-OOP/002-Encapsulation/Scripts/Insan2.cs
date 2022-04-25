using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insan2 : MonoBehaviour
{
    

     void Start()
    {
        SifreOlustur();
        //InsanOlustur();
    }


    void InsanOlustur()
    {

        Insan _insan1 = new Insan();
        _insan1.FirstName = "Davut";
        _insan1.LastName = "ASKAR";
        _insan1.Age = 29;

        Insan _insan2 = new Insan();
        _insan2.FirstName = "Mehmet";
        _insan2.LastName = "BOZKURT";
        _insan2.Age = 35;



    }

    void SifreOlustur()
    {
        Insan _sifre = new Insan();
        _sifre.Sifre = "Ozgur123";
    }
}
