using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Araba 
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public bool SifirMi { get; set; }
    public float Hiz { get; set; }
    public byte KapiSayisi { get; set; }
    public decimal Fiyati { get; set; }
    public decimal ToplamFiyati { get; protected set; }         //değişmemesi için protected yaptık.

    public virtual void SatisYap()//virtual method diğer classlar içinde özelleştirilip tek bir method içinde kullanımı sağlar
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 7000m;
        }
        
    }

    //bir methodu virtual yapıyorsan onu override etmen gerekir.

}
