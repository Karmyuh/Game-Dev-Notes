using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EventsOrnek : MonoBehaviour
{
    delegate void _delegateOrnek();

    event _delegateOrnek _eventOrnek; // C# event 

    event Action<int,int,int> OrnekEvent;
    event Action<int> Patates;

    void deneme2(int a)
    {

    }
   
    void deneme(int a , int b , int c)
    {
        OrnekEvent += EventsOrnek_OrnekEvent;
    }
    
    

    private void EventsOrnek_OrnekEvent(int arg1, int arg2, int arg3)
    {
        throw new NotImplementedException();
    }
}
