using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio_2_1 : MonoBehaviour
{
    //RECUERDA: usa siempre [SerializeField] en vez de public en una variable o método que quieras usar (salvo por casos especiales)

    int puntosDeValentia = 12;
    int puntosDeIntuicion = 14;
    int puntosDeInteligencia = 15;

    int vidasPlayer1 = 1;
    int vidasPlayer2 = 2;
    int vidasPlayer3 = 5;
    int vidasPlayer4 = 10;
    char carac;
    float exp = 3.1f;
    int pocion = 7;
    float vidas = 5;
    // si la variable vida fuera int y se sumara con la variable char, darían error y no
    // se podría ejecutar el juego

    public string clase = "mago";
    int edad = 10;
    float altura = 1.85f;
    [SerializeField] string nombre = "Dan";//nota: public muestra las variables y se pueden modificar; serializedfield solo se puede mostrar en unity a aquellos objetos que contengan este script.
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

        int puntosDeResurreccion = revive() + contador;//junto con "return" en el metodo variable "revive", puedes usar la variable "revive" en otra variable como un dato o valor
        //ES OBLIGATORIO QUE ESTÉ RETURN DENTRO DEL METODO VARIABLE DESEADO PARA QUE ESTO FUNCIONE.

        Debug.Log("-----------------------------");

        vidas += 77;
        Debug.Log("vidas: " + vidas);
        vidas -= 3;
        Debug.Log("vidas: " + vidas);
        vidas *= 2;
        Debug.Log("vidas: " + vidas);

        Debug.Log("-----------------------------");

        vidasPlayer2 = vidasPlayer3;
        Debug.Log("vidas de player2= " + vidasPlayer2);
        vidasPlayer3 = vidasPlayer1;
        Debug.Log("vidas de player3= " + vidasPlayer3);
        vidasPlayer1 = vidasPlayer4;
        Debug.Log("vidas de player1= " + vidasPlayer1);
        vidasPlayer4 = vidasPlayer2;
        Debug.Log("vidas de player4= " + vidasPlayer4);

        Debug.Log("-----------------------------");
        Debug.Log("vidas de player4= " + vidasPlayer4);
        //IMPORTANTE (EJERCICIO 2.6): PARA CALCULAR LA MEDIA, DEBES SUMAR TODOS LOS VALORES Y DIVIDIR EL RESULTADO POR EL NUMERO DE VALORES





    }

    // Update is called once per frame
    void Update()//update y start se ejecutan automáticamente; el resto de métodos no lo hacen
    {
        //Debug.Log("Ha pasado un frame");//Este mensaje aparece porque, constantemente, esta función se actualiza
        revive(3, "veneno");//este "metodo" se puede poner en el update, pero no es necesario.
        //

    }
    int revive(int amenaza = 1, string estado = "nulo", int rondas = 0)//se ejecutará cuando lo llammes. Puedes declarar una variable local, la cual solo se usará en este método.
        //ten en cuenta que ES OBLIGATORIO poner a estas variables un dato o valor, puesto que, sin ellos, las variables locales no funcionan.
        
    {
        int carro = amenaza + rondas;
        return carro;// devuelve el valor de la variable "carro"a la variable del metodo "revive" (se puede poner la variable, por ejemplo, "int" en vez de "void")
        //

    }
}
