using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBomba : MonoBehaviour
{
    private void Start()
    {
        BombaOlustur();
    }

    void BombaOlustur()
    {
        MaviBombaOlustur();
        KirmiziBombaOlustur();
        SariBombaOlustur();
    }

    public void MaviBombaOlustur()
    {
        MaviBomba _maviBombaOlustur = new MaviBomba() { BombaAdi = "Gazanfer", BombaBuyuklugu = 200, BombaID = 31, BombaRengi = "Mavi", EstraHasar = true, Hasari = 331 };

    }

    public void KirmiziBombaOlustur()
    {
        KirmiziBomba _kirmiziBombaOlustur = new KirmiziBomba() { BombaAdi = "Murat", BombaBuyuklugu = 230, BombaID = 32, BombaRengi = "Kırmızı", EkstraCan = true, Hasari = 500 };
    }

    public void SariBombaOlustur()
    {
        SariBomba sariBomba = new SariBomba() { BombaAdi = "Semiha", BombaBuyuklugu = 150, BombaID = 28, BombaRengi = "Sapsarı", EstraYetenek = true, Hasari = 250 };
    }
}
