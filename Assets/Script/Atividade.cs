using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    //Declarar 3 classes de texto
    //Implementar valor somente 1º
    //alterar a 1º variavel

    //Na função Start
    //concatenar a 1º e 2º na 3º Variavel

    [SerializeField] string _nome = "Bruna";
    [SerializeField] string _sobrenome;
    [SerializeField] string _nomecompleto;
    // Start is called before the first frame update
    void Start()
    {
        _nome = "Mary";
        _nomecompleto = _nome + " " + _sobrenome;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
