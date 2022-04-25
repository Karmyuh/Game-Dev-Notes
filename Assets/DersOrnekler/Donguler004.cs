using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donguler004 : MonoBehaviour
{
    // ----------------OPERATORLER VE DONGULER------------------- ^.$\n
    // AYVANSARAY UNI. DERS NOTLARI - OGRETMEN: D. DAVUT ASKAR


    // 1 While 2 Do While 3 For 4 Foreach
    // 1 2 ve 3. dongude sayac belirtme zorunlulugumuz vardir.
    void Start()
    {
        //Debug.Log("Calisti");
        //Debug.Log("Calisti");
        //Debug.Log("Calisti");
        //Debug.Log("Calisti");
        //Debug.Log("Calisti");
        //Debug.Log("Calisti");
        //Debug.Log("Calisti");  Tekrar etme islemi yaptirmak istiyorsak cok fazla kod yazmak gerekir. Orn; 10k

        ForDongusu();
    }

    void WhileDongusu()
    {
        int sayac = 10; // genelde index kelimesi kullanilir.



        while (sayac < 10)
        {
            Debug.Log("Calisti.");
            sayac++; // arttirilmaz ise sonsuz donguye girer.
        }
    }


    void DoWhileDongusu()
    {
        // While, sart saglandiginda icine bir daha girmez ve calismaz. Fakat do ile kullanildiginda bir kere calisir ve devam eder.
        do
        {
            Debug.Log("Sart saglansin ya da saglanmasin calisir.");
        } while (false);
    }

    void ForDongusu()
    {
        //  sayac sart   sayacArtis
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Calisti");
        }

        // ----------

        for (int i = 0; i < 10; i++)
        {
            if (i > 2)
            {
                break; // kir ve programdan cik
            }

            Debug.Log(i);
        }

        //--------

        for (int i = 0; i < 10; i++)
        {
            if (i == 2)
            {
                continue; // 2yi atla ve devam et.
            }

            Debug.Log(i);
        }
    }

    //While ile farki, bazen sayac arttirilmasi unutulur ve yazilmaz. For da ise boyle bir secenek yoktur. Daha fazla kullanilir.

    void Foreach()
    {
        //foreach (var item in collection)
        //{

        //}
    }

    //While ile farki, bazen sayac arttirilmasi unutulur ve yazilmaz. For da ise boyle bir secenek yoktur. Daha fazla kullanilir.

}
