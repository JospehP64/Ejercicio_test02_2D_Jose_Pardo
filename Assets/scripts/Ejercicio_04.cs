using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio_04 : MonoBehaviour
{
    [SerializeField] float radio;
    [SerializeField] float perimetro;
    [SerializeField] float altura;
    [SerializeField] float lado_largo;
    [SerializeField] float lado_ancho;
    
    // Start is called before the first frame update
    void Start()
    {
        //EJERCICIO 4.1
        //C�rulo
        float area = CalcularAreaCirculo(radio);

        Debug.Log("El 1� enemigo tiene un �rea de " + area + " m�");
        Debug.Log("------------------------------");
        //tri�ngulo
        float area02 = CalcularAreaTriangulo();
        Debug.Log("El 2� enemigo tiene un �rea de " + area02 + " m�");
        //rect�ngulo
        float area03 = CalcularAreaTriangulo();

        Debug.Log("------------------------------");
        Debug.Log("El 3� enemigo tiene un �rea de " + area03 + " m�");

        //EJERCICIO 4.2

        
    }

    float CalcularAreaCirculo(float radio)
    {
        float area = radio * radio * Mathf.PI;
        return area;
    }


    float CalcularAreaTriangulo()
    {
       float area02 = perimetro * altura / 2;
        return area02;
    }

    float CalcularAreaRect�ngulo()
    {
       float area03 = lado_largo * lado_ancho;
        return area03;
    }

    void ConstruirNombre()
    {
        string nombre;
        string apellido;
        int edad;
        //return nombre;
        //return apellido;
       // return edad;
        //���URGENTE: TERMINAR DEL EJERCICIO 4.2 AL 7!!!

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
