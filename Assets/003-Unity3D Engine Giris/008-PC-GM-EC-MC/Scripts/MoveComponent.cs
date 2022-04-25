using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : Imoverscript 
{
   
    public float Jump => Input.GetAxis("Jump");

    public void JumpAxis(Rigidbody2D _rigidbody2D, float _forceSpeed, bool _canJump)
    {
        
                _rigidbody2D.AddForce(Vector2.up * Jump * _forceSpeed );
        
    }

}
