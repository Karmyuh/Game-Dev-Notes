using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorlerVeKararYapilari003 : MonoBehaviour
{

    // ----------------OPERATORLER VE DONGULER------------------- ^.$\n
    // AYVANSARAY UNI. DERS NOTLARI - OGRETMEN: D. DAVUT ASKAR

    // ARITMETIK OPERATORLER
    //    + , ‐ , * , /, ++ , -- ve % aritmetik operatorlerdir.
    // /, *, + ve – operatorleri matematiksel islemler yapar.
    // % operatoru ise bolumden sonra kalani bulmak yani "mod" almak icin kullanilir.
    // ++ ve -- islemin uygulandigi sayiyi 1 arttirir veya 1 azaltir.
    // *, /, % operatorleri ayni satirdaysa esit oncelige sahiptir. + ve – operatorleri de ayni satirdaysa esit onceliklidir fakat*, /, % operatorlerinin + ve – operatorlerine gore onceligi vardir.

    // KARSILASTIRMA OPERATORLERI
    // C#’ ta 6 adet karsilastirma operatoru vardir. Bunlar; <(kucuktur), >(buyuktur), <=(kucuk veya esittir), >=(buyuk veya esittir), ==(esittir), !=(esit degildir).

    // MANTIKSAL OPERATORLER
    // C#’ ta 3 adet mantiksal operator bulunmaktadir. Bunlar; &&(ve), !(degil), ||(veya) operatorleridir.

    // ATAMA OPERATORLERI
    //    =(atama) operatoru bir degiskene herhangi bir deger atamak icin kullanilir.

    // *=, /=, +=, -=, &=, ^=, |= gibi operatorlere islemli atama operatoru denir. Kullanimi su sekildedir;

    

   

    [SerializeField]
    private int _sayi;

    [SerializeField]
    private string ay;

    void Start()
    {
        SayiKontrolu();
    }

    // Update is called once per frame


    void SayiKontrolu()
    {
        if (_sayi < 10) // her zaman bool sonuc dondurur.
        {
            Debug.Log("Sayi 10dan kucuktur.");
        }

        else if (_sayi == 10)
        {
            Debug.Log("Sayi 10a esittir.");
        }

        else
        {
            Debug.Log("Hic bir sonuc karsilanmadi."); // Hic bir sonuc karsilanmadiginda dondurur.
        }


        // ----------------TernaryIF-------------------
        //                                TRUE                                    FALSE
        Debug.Log(_sayi == 10 ? "sayi 10a esit ternary if calisti" : "sayi 10a esit degil, terbaryIf calismadi."); // Hic bir sonuc karsilanmadiginda dondurur.
                                                                                                                   //IF Else nin kisa yazim hali
    }

    void AyKontrolu()
    {
        switch (ay)
        {
            case "Ocak":
                Debug.Log("Ocak Ayi."); // Hic bir sonuc karsilanmadiginda dondurur.
                break; // Break: Kir ve cik demektir.

            case "Subat Ayi":
                Debug.Log("Subat Ayi."); // Hic bir sonuc karsilanmadiginda dondurur.
                break; // Break: Kir ve cik demektir.

            default:
                Debug.Log("Ocak Ayi."); // Hic bir sonuc karsilanmadiginda dondurur.
                break;

        }
    }


}
