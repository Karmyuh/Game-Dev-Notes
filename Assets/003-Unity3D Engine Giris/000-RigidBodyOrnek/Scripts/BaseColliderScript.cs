using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseColliderScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Seker")
        {
            Destroy(collision.gameObject);
            Debug.Log("Dusmana Çarptı");
        }
    }
}
