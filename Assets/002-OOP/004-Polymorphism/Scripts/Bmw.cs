using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Bmw : Araba , IAlman

{

    public bool UcuyorMu { get; set; }
    public bool AlmanMi { get; set; }

    public override void SatisYap()
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 17000m;
        }
        if (UcuyorMu)             
        {
            ToplamFiyati += 5000m;
        }
    }
    public void AlmanSatisYap()
    {
        if (AlmanMi)
        {
            ToplamFiyati -= 50000m;
        }
    }
}
