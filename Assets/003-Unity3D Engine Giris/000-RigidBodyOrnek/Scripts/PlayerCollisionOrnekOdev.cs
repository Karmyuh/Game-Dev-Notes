using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisionOrnekOdev : MonoBehaviour
{
    [SerializeField] Text _score;
    int skor;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Seker")
        {
            Destroy(collision.gameObject);
            Debug.Log("Dusmana Çarptı");
        }

        if (collision.gameObject.tag == "SariSeker")
        {

            skor += 1;
            
            Destroy(collision.gameObject);
            _score.text=($"Toplanan Seker:{skor}");
        }

    }
}
