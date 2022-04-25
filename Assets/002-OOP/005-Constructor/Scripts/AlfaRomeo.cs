using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlfaRomeo : Araba
{

    //ctor tab tab

    public bool UcuyorMu { get; set; }

    public AlfaRomeo(string _marka, string _model, int _hiz, byte _kapiSayisi,bool _ucuyorMu)
    {
        //bu method burada gözükmese bile arka planda vardır. bu bir yapıcı methoddur. Yapıcı methodlar, "n" kadar yüklenici (overload) alabilir.
        Marka = _marka;
        Model = _model;
        Hiz = _hiz;
        KapiSayisi = _kapiSayisi;
    }
}
