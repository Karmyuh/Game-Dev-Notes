using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nkadardegerornek : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        arrayolustur(1,2,3,4,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void arrayolustur(params int[] arrayornek )
    {

        foreach (var item in arrayornek)
        {
            Debug.Log($"Array ici {item}");
        }

        

    }
}
