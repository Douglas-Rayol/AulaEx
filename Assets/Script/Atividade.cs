using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    //Declarar 3 classes de texto
    //Implementar valor somente 1�
    //alterar a 1� variavel

    //Na fun��o Start
    //concatenar a 1� e 2� na 3� Variavel

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
