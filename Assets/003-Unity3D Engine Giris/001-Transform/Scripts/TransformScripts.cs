using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScripts : MonoBehaviour
{

    private void Start()
    {

        transform.position = new Vector3(0.2f, 5);
        transform.rotation = new Quaternion(100, 0, 0, 0);
        transform.localScale = new Vector3(1, 1, 1);



    }





}
