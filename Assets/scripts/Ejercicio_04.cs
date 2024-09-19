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
    [SerializeField] float velocidadEnKM = 10;
    float areaMoneda = area;
    float areaMoneda02 = area02;
    float areaMoneda03 = area03;

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
        var (nombre, apellido, edad) = ConstruirNombre();
        Debug.Log("Mi nombre es " + nombre + " " + apellido + " y tengo " + edad + " años");

        //EJERCICIO 4.3
        var (cantidad, moneda) = Convertir();
        if (moneda == "euros")
        {
            Debug.Log("Se han convertido los dólares seleccionados a " + cantidad + " " + moneda);
        }
        else
        {
            Debug.Log("Se han convertido los dólares seleccionados a " + cantidad + " " + moneda);
        }

        //EJERCICIO 4.4
        float velocidadEnM = ConvertirVelocidad();
        Debug.Log(velocidadEnKM + " Km/h es igual a " + velocidadEnM + " m/h.");

        //EJERCICIO 4.5

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

      (string, string, int) ConstruirNombre()
    {
        string nombre = "Dario";
        string apellido = "Patrán";
        int edad = 20;
        return (nombre, apellido, edad);
        //recuerda: Para que se puedan usar varias variables a la vez, necesitas poner en parentesis y separado por comas (no comillas ;) todas las variables que
        //vas a usar. Y, para poder usar las variables fuera del método, primero tienes que devolver el valor con return y () con comas; después, fuera del método,
        //tienes que poner var (variables en comas)

    }

    (float, string) Convertir()
    {
        string moneda = "dolar";
        float cantidad = 50;
        if (moneda == "euro")
        {
            cantidad = cantidad / 0.90f;

        }
        else
        {
            cantidad = cantidad / 1.11f;
        }
        return (cantidad, moneda);
    }

    float ConvertirVelocidad()
    {
        float velocidadEnM = 0;
        
        velocidadEnM = velocidadEnKM * 100;
        
        
        return (velocidadEnM);
    }

    (float, string) ConvertirFiguraAMoneda(float areaMoneda = 1)
    {
       

        string moneda = "dolar";
        float cantidad = 50;
        if (moneda == "euro")
        {
            cantidad = cantidad / 0.90f;

        }
        else
        {
            cantidad = cantidad / 1.11f;
        }
        return (cantidad, moneda);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
