using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio_2_1 : MonoBehaviour
{
   
    
    char carac;
    float exp = 3.1f;
    int pocion = 7;
    float vidas = 5;
    // si la variable vida fuera int y se sumara con la variable char, darían error y no
    // se podría ejecutar el juego


    int edad = 10;
    float altura = 1.85f;
    string nombre = "Dan";
    float iva = 3.5f;//valores en % a aplicar
    float peso = 5.75f;
    bool AlumnoRepetidor = false;
    char letra = 'A';
    int minutos = 5;//sin los segundos
    bool MatriculaCoche = false;
    bool MayorDeEdad = false;
    int CodigoPostal = 28999;
    char genero = 'M';
    int NumeroDeHijos = 0;
    float TallaDeCamisa = 3.33f;
    float precio = 5.59f;
    string mensaje = "";
    bool MayorEdad = false;
    int dias = 1000;
    int contador = 1;
    char tallaCamiseta = 'L';


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Este es el primer videojuego de Jose Manuel Pardo Beltran"); //(casi el primero)
        Debug.Log("Estoy aprendiendo C#");
        //vidas += 3; // -=, restar; +=, sumar; /=, dividir; *=, multiplicar
        //vidas += pocion;// sumas los valores de vida con los de pociones. puedes tambien realizar más de una operacion de la sieguiente manera

        //(vida += pocion) * 10
        Debug.Log("empiezo con " + vidas + " de vida");
        //vidas -= 3;
         float resultadoSuma = vidas += exp;
        float resultadoResta = vidas -= exp;
        Debug.Log("Resultado de suma = " + resultadoSuma);
        Debug.Log("Resultado de resta = " + resultadoResta);

        float resultadoProducto = vidas *= exp;
        Debug.Log("Resultado de multiplicación = " + resultadoProducto);
        float resultadoCociente = vidas /= exp;
        Debug.Log("Resultado de división = " + resultadoCociente);
        float dobleDeVidas = vidas *= 2;
        Debug.Log("El doble de vidas = " + dobleDeVidas);
        float tripleDeExp= exp *= 3;
        Debug.Log("El triple de experiencia = " + tripleDeExp);


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Ha pasado un frame");//Este mensaje aparece porque, constantemente, esta función se actualiza

    }
}
