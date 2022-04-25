using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallHareket : MonoBehaviour
{
    
    [SerializeField] Rigidbody2D _fireBall;
    [SerializeField] float _hiz; 

    private void FixedUpdate()
    {
        FireHareket();
    }

    void FireHareket()
    {
        _fireBall.velocity = Vector2.right * _hiz;
    }

    

}
