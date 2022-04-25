using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbodyornekscript : MonoBehaviour
{
    [SerializeField] GameObject _seker;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Dusman")
        {
            Destroy(this.gameObject);
            Debug.Log("Dusmana Çarptı");
        }
        if (collision.gameObject.tag == "Seker")
        {
            Destroy(_seker.gameObject);
            Debug.Log("Seker Topladin");
        }

    }
}
