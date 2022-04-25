using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrollerornek : MonoBehaviour
{
    [SerializeField] GameObject _obje;

    [SerializeField] float _hiz;

    private void FixedUpdate()
    {
        _obje.transform.position += new Vector3(Input.GetAxis("Horizontal") * _hiz * Time.deltaTime, Input.GetAxis("Vertical") * _hiz * Time.deltaTime);
    }


}
