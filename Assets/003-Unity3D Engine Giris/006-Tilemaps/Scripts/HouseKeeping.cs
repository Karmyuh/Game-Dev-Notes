using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class HouseKeeping : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidbody2D;
    [SerializeField] SpriteRenderer _house;
    [SerializeField] Tilemap _background;
    [SerializeField] Text _text;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            _house.color = Color.green;
            _background.color = Color.green;
            _text.text = "Davut hocanın evi";
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _house.color = Color.red;
            _background.color = Color.red;
            _text.text = "ebeni görürsün birazdan";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            _rigidbody2D.gravityScale = 1;
        }
    }
}
