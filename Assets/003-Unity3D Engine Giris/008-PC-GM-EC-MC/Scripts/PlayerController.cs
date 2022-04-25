using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    [Header("Karakter Zıplama Gücü")] [Range(250,400)] [SerializeField] float _forceSpeed = 350;
    [Header("Karakter Zıplama Ayarı")] [SerializeField] bool _canJump;
    Rigidbody2D Rigidbody ;
    MoveComponent Move  ;
    private void Awake()
    {
        Move = new MoveComponent();
        Rigidbody = GetComponentInChildren<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _canJump = true;
        }
    }
    private void FixedUpdate()
    {
        if (_canJump)
        {
            Move.JumpAxis(Rigidbody, _forceSpeed, _canJump);
        }
        _canJump = false;  
    }
}
