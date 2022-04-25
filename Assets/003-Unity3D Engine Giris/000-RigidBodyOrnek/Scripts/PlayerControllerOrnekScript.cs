using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerOrnekScript : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] float _hiz;
    private void FixedUpdate()
    {
        hareket();
    }

    void hareket()
    {
        _player.transform.position += new Vector3(Input.GetAxis("Horizontal") * _hiz * Time.deltaTime,

           Input.GetAxis("Vertical") * _hiz * Time.deltaTime);
    }



}
