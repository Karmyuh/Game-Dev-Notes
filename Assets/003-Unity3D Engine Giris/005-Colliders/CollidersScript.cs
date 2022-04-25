using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidersScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Çal??t?");
    }

    //------------------------------------------------------

    //Objede is trigger aktif ise ;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Çal??t?");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Çal??t?");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
