using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBunnyOrnek : MonoBehaviour
{
    [SerializeField] float _hSpeed, _vSpeed,_jspeed;
    [SerializeField] bool _isJump;
    [SerializeField] GameObject _gameObject;
    Rigidbody2D _rigidbody;

    public bool IsJumpAction => _rigidbody.velocity != Vector2.zero;

    private void Awake()
    {
        _rigidbody = GetComponentInChildren<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Hareket();
        Jump();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _isJump = true;
        }
        else
            _isJump = false;

    }
    public void Hareket()
    {
        _gameObject.transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * _hSpeed, 0);
    }
    public void Jump()
    {

        if (_isJump && !IsJumpAction)
        {
            _rigidbody.AddForce(Vector2.up * _jspeed);
        }
        else
        {
            _isJump = false;
        }
    }

  

   


}
