using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainsArabalar : MonoBehaviour
{
    [SerializeField] InputField _markaField, _modelField, _hizField, _fiyatField;
    [SerializeField] Button _saveButton;
    

    // Start is called before the first frame update
    void Start()
    {
        ArabaOlustur();

        AlfaRomeo _alfa = new AlfaRomeo("AlfaRomeo", "CCN", 200, 4,true);
    }


    void ArabaOlustur()
    {
        Bmw _b = new Bmw();
        _b.Marka = "BMW";
        _b.AlmanMi = false;
        _b.AlmanSatisYap();
    }

    public void InputController()
    {
        if (_markaField.text != "" && _modelField.text != "" && _hizField.text != "" && _fiyatField.text != "")
        {
            _saveButton.interactable = true;
            
        }
        else
        {
            _saveButton.interactable = false;
        }
    }

    public void Save()
    {
        
        Debug.Log($"Marka ={_markaField.text}, Model= {_modelField.text}, Hýz= {_hizField.text}, FÝAT= {_fiyatField.text}");
    }


    // Update is called once per frame
    void Update()
    {
        InputController();
    }
}
