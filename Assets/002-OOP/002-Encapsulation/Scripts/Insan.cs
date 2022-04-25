using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insan //insan nesnesi oluşturulur
{

    //public string _firstName;
    //public string _lastName;
    int _age;
    string _sifre;


    //public int MyProperty { get; set; } //prop tab tab yapınca çıkar

    //public string _Adi { get; set; } //bilgiyi okumak istediğimizde get çalışır. Bilgiyi almak için set çalışır.

    //En özgün erişilebilir olan sırasıyla: public, internal, protected, private;


    //new property
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    //public int Age { get; set; } //Encapsulation Uygulanacak.


    //new property oluşturulurken fieldlara ihtiyaç duymayız. 

    //old property
    public int Age { 
        get 
        {

            return _age;        
        }
        set 
        {
            if (value < 18 || value > 100)
            {
                Debug.Log("Geçerli bir yaş giriniz.");
            }
            else
            {
                _age = value; //girilen value u age e atayacak   
            }
              
        } }

    public string Sifre 
    {
        get 
        {
            return _sifre;
        
        }
        set 
        {
            if (value.Length>10)
            {
                Debug.Log("Şifre 10 haneden küçük olmalı");
            }
            else
            {
                _sifre = value;
                Debug.Log("Aferin güzel kardeşim");
            }
        
        
        } }
}
