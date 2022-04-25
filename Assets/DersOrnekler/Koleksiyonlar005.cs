using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Koleksiyonlar005 : MonoBehaviour
{
    //Dizileri ve listleri new lememize gerek yoktur. Inspectorde diziler boyle de kullanilabilir.
    //Dictionary serializeField olsa bile , Inspector panelinde gozukmezler. Unity bunu cozumleyemez. Fakat "Odin Inspector" adli 3. taraf ucretli paketlerle bu Inspector penceresinde gosterilebilir.

    [SerializeField] int[] ornekDizi1;
    [SerializeField] List<int> listeOrnek1;
    [SerializeField] Dictionary<int, string> DictionaryOrnek1;
    [SerializeField] Queue<string> days;

    private void Start()
    {
        //ArrayOrnek();
        //ListOrnek();
        //DictionaryOrnek();
        QueueyOrnek();
    }

    public void ArrayOrnek()
    {

        ////ARRAY DIZI
        //  int[] ornekDizi = new int[3];

        //ornekDizi[0] = 10;
        //ornekDizi[1] = 20;
        //ornekDizi[2] = 30;
        //ornekDizi[3] = 30; // hatali yazimdir. 3 index belirtilmistir.

        //for (int i = 0; i < ornekDizi.Length; i++)
        //{
        //    Debug.Log(ornekDizi[i]);
        //}

        //for (int i = 0; i < 3; i++)
        //{
        //    Debug.Log(ornekDizi[i]);
        //}

        // kisa yazim
        //int[] ornekDizi2 = new int[3] { 11, 22, 33 };

        //foreach (var item in ornekDizi2)
        //{
        //    Debug.Log(item);
        //}
    }

    public void ListOrnek()
    {
        //List<int> listeOrnek = new List<int>();
        //listeOrnek.Add(100);
        //listeOrnek.Add(200);
        //listeOrnek.Add(300);
        //listeOrnek.Add(400);
        //listeOrnek.Add(500);

        //for (int i = 0; i <5; i++)
        //{
        //    Debug.Log(listeOrnek[i]);
        //}

        //for (int i = 0; i < listeOrnek.Count; i++)
        //{
        //    Debug.Log(listeOrnek[i]);
        //}

        //// kisa yazim
        //List<int> listeOrnek = new List<int>() { 100, 200, 300, 400, 500, 600 };

        //foreach (var item in listeOrnek)
        //{
        //    Debug.Log(item);
        //}
    }

    public void DictionaryOrnek()
    {
        //Dictionary<int, string> dictionaryOrnekleri = new Dictionary<int, string>();
        //dictionaryOrnekleri.Add(1, "kalem");
        //dictionaryOrnekleri.Add(2, "silgi");
        //dictionaryOrnekleri.Add(3, "kitap");
        //dictionaryOrnekleri.Add(4, "defter");
        //dictionaryOrnekleri.Add(5, "tahta");
        ////dictionaryOrnekleri.Add(5, "tahta"); // ayni key oldugu icin hata verir ve calismaz.
        //// Bir dictionary icerisinde "keyler" benzersiz olmalidir.
        //foreach (var item in dictionaryOrnekleri)
        //{
        //    Debug.Log(item);
        //}
    }

    public void QueueyOrnek()
    {
        Queue<string> days = new Queue<string>();


        days.Enqueue("Pazartesi");
        days.Enqueue("Sali");
        days.Enqueue("Carcamba");


        for (int i = 0; i < 1; i++)
        {
            Debug.Log(days.Dequeue());
        }

        //foreach (var item in days)
        //{
        //    Debug.Log(item);
        //}



        ////Queue koleksiyon yapisinda ilk giren ilk cikar. Enqueue ekle, Dequeue cikar anlamina gelmektedir.
    }
}
