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
        //Círulo
        float area = CalcularAreaCirculo(radio);

        Debug.Log("El 1º enemigo tiene un área de " + area + " m²");
        Debug.Log("------------------------------");
        //triángulo
        float area02 = CalcularAreaTriangulo();
        Debug.Log("El 2º enemigo tiene un área de " + area02 + " m²");
        //rectángulo
        float area03 = CalcularAreaTriangulo();

        Debug.Log("------------------------------");
        Debug.Log("El 3º enemigo tiene un área de " + area03 + " m²");

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

    float CalcularAreaRectángulo()
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
        //¡¡¡URGENTE: TERMINAR DEL EJERCICIO 4.2 AL 7!!!

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
