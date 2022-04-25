using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferrari : Araba
{
    public bool ZipliyorMu { get; set; }


    public override void SatisYap()
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 99999900m;
        }
        if (ZipliyorMu)
        {
            ToplamFiyati += 5000m;
        }
    }

}
