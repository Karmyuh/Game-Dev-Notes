using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLifeCycle : MonoBehaviour
{

    [SerializeField] float _treeLifeTime;
    float _currentTime;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _treeLifeTime)
        {
            Destroy(this.gameObject);
        }
    }





}
