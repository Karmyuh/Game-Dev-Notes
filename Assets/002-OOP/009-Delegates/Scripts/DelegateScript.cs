using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour
{

    /*
        Delegate 

    Program icerisinde bir ya da birden fazla metodu gosteren(isaret eden) , referans turunden bir nesnedir.
        
    */

    public delegate void DelegateOrnek(int a);

    void metot1(int a) 
    {
        Debug.Log("5");
    }
    void metot2(int a) 
    {
        Debug.Log("10");
    }
    void metot3(int a) 
    {
        Debug.Log("15");
    }

    void Ozgur(int a,int b,int c)
    {

    }

    private void Start()
    {
        DelegateOrnek delegateOrnek = new DelegateOrnek(metot1);
        delegateOrnek += metot2;
        delegateOrnek += metot3;
    }



}
