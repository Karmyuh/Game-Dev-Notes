using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSpawner : MonoBehaviour
{

    [SerializeField] GameObject _Fire;
    [SerializeField] Transform _Body;

    private void Update()
    {
        Fire();
    }

    void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_Fire, _Body.position, _Body.rotation);
        }
    }


}
