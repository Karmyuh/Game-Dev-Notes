using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    [SerializeField] SpriteRenderer _playerSpriteRenderer;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _playerSpriteRenderer.flipX = true;
            transform.position += new Vector3(Time.deltaTime * -15, 0);
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _playerSpriteRenderer.flipX = false;
            transform.position += new Vector3(Time.deltaTime * 15, 0);
            
        }
       
        else
        {
            
        }
    }


    private void FixedUpdate()
    {
        
    }


}
