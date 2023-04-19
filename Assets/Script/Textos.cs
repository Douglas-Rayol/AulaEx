using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    //descrições de texto
    [SerializeField] string _nome = "Luide";
    [SerializeField] string _sobrenome;
    [SerializeField] string _nomecompleto;
    [SerializeField] Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _nome = "Jorge";
        _nomecompleto = _nome + " " + "de" + " " + _sobrenome;
        _text.text = _nomecompleto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
