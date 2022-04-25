using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAlman 
{
    //int a = 2; //değişken atayamıyorum
    
    //void Deneme()   //method oluşturamıyorum.
    //{

    //}

    //C# 8.0 için durumlar böyle değildir.
    
    
    public bool AlmanMi { get; set; } //interface olarak bütün proplar publictir.

    public void AlmanSatisYap();

}
