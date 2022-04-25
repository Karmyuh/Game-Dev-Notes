using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerScript : MonoBehaviour
{

    bool _sagaBasildi, _solaBasildi, _yukariBasildi, _asagiBasildi;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _sagaBasildi = true;
        }
    }

    private void FixedUpdate()
    {
        hareket();
    }

    void hareket()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.2f, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(0.2f, 0);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.2f);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0, 0.2f);
        }

        Debug.Log(Input.GetAxis("Horizontal"));

    }



}
