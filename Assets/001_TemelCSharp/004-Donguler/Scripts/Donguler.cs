using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donguler : MonoBehaviour
{

    //While
    //Do While
    //For
    //Foreach
    //Foreach dışındaki tüm döngülerde sayaç(index) belirtme zorunluluğu vardır.
    [SerializeField] int _sayac;
    //List<string> Ogrenciler = new List<string>() { "Ali", "Veli" };

    void Start()
    {
        //WhileDongusu();
        // DoWhileDongusu();
        //ForDongusu();
        ForeachDongusu();

        

    }


    void WhileDongusu()
    {


        while (_sayac < 11)
        {
            Debug.Log("Çalıştır");
            _sayac++;
        }
    }



    void DoWhileDongusu()
    {
        do
        {
            Debug.Log("Çalıştı");
        } while (false);

        //while şartı sağlansa da sağlanmasa da 1 kez çalışır.

    }

    void ForDongusu()
    {
        for (int i = 1; i < 11; i++)
        {
            Debug.Log("Çalıştı");
        }
    }



    List<string> Ogrenciler = new List<string>() { "Ali", "Veli" };
    void ForeachDongusu()
    {
        

        foreach (var item in Ogrenciler)
        {
            Debug.Log(item);
        }


    }
}
