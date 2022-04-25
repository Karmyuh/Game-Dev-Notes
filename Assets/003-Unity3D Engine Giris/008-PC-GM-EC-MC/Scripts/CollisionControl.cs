using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dusman")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
