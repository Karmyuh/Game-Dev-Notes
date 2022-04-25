using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plakalarvesehirler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        dicOlustur();
    }

    void dicOlustur()
    {

        Dictionary<int , string> _dicOrnek = new Dictionary<int, string>();
        _dicOrnek.Add(1, "ist");
        _dicOrnek.Add(2, "ada");
        _dicOrnek.Add(3, "koca");
        _dicOrnek.Add(4, "trab");
        _dicOrnek.Add(5, "izmr");

        foreach (var item in _dicOrnek)
        {
            Debug.Log($"Sehirler {item.Value}");
        }
    }
}
