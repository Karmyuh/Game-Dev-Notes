using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _agacrigid;
    [SerializeField] float _treeSpeed;
    private void Awake()
    {
        _agacrigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        TreeMove();
    }

    public void TreeMove()
    {
        _agacrigid.velocity = Vector2.left * Time.deltaTime * _treeSpeed;
    }

}
