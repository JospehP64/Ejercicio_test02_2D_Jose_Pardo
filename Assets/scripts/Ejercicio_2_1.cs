using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio_2_1 : MonoBehaviour
{
    //RECUERDA: usa siempre [SerializeField] en vez de public en una variable o método que quieras usar (salvo por casos especiales)

    int Monedas;
    int horas = 0, minutos = 0, segundos = 0, milisegundos = 0;

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
        //TERMINAR_IMPORTANTE (EJERCICIO 2.6): PARA CALCULAR LA MEDIA, DEBES SUMAR TODOS LOS VALORES Y DIVIDIR EL RESULTADO POR EL NUMERO DE VALORES
        int puntosDeValentia = 12;
        int puntosDeIntuicion = 14;
        int puntosDeInteligencia = 15;
        int sumaPuntos;
        int puntuacionTotal;

        puntuacionTotal = (puntosDeValentia + puntosDeIntuicion + puntosDeInteligencia);

        Debug.Log("");




        //EJERCICIO 6.1, OPERADORES LÓGICOS 
        //a)
        //Se cumple solo si X es verdadero e Y es falso o si X es falso y Z es verdadero

        //b) 
        //solo se cumple si X es verdadero, Y es falso o  X es verdadero y Z es falso y Y es falso

        //c)
        //Solo se cumple si X es verdadero o si Y es falso y Z es verdadero

        //d)primero se comrobaría si X es verdadero o Y es falso; después, si X es falso o si Z es verdadero
        //y, por último, se comprobaría si las dos condiciones anteriores, se cumplen.

        //Si en la ultima condición una de ellas no se cumple, no se puede ejecutar el contenido.

        //e)Solo se cumle si X es verdadero, Y es falso o si X es verdadero y Z es falso y Y verdadero

        //f) Solo se cumple si X es falso, Y es verdadero o Z es verdaderoy X es verdadero y Y es verdadero

        //EJERCICIO 2.7: Crear un programa que te diga el número de monedas obtenido en 4 horas (usar variables para moneda y para el tiempo medido)

        if (horas == 4)
        {
            Debug.Log("has conseguido " + Monedas + " monedas durante " + horas + " horas.");

        }
        else
        {
            //Debug.Log("horas: " + horas + ", minutos: " + minutos + ", segundos: " + segundos + " milisegundos: " + milisegundos);
            Debug.Log("Monedas obtenidas: " + Monedas);
            if (milisegundos >= 60)
            {
                segundos += 1;
                Monedas += 1;
                milisegundos = 0;
                if (segundos >= 60)
                {
                    minutos += 1;
                    segundos = 0;
                }
                if (minutos >= 60)
                {
                    horas += 1;
                    minutos = 0;
                }
            }
            else
            {
                milisegundos += 1;

            }
        }

        //EJERCICIO 2.8:
        int vida_rpg = 120;
        int veneno_en_porcentaje = 3;
        int venenoAtaque;
        int numeroDeTurno = 0;

        while (vida_rpg > 0)
        {
            Debug.Log("¡Has sido envenenado!");
            venenoAtaque = (vida_rpg * veneno_en_porcentaje) / 100;
            vida_rpg = vida_rpg - venenoAtaque;
            Debug.Log("¡Has recibido daño! Te quedan " + vida_rpg + " puntos de vida");
            numeroDeTurno++;
            veneno_en_porcentaje *= 2;
        }
        if (vida_rpg <= 0)
        {
            Debug.Log("has muerto...");
        }

        //RECUERDA: para poder calcular un numero par o impar, tienes que usar en if el  cociente (%) (el resto sería /) de esta forma if (variable % dato == dato)
        //por ejemplo: cuando usas "if (dias % 7 == 1)", estás comprobando el número impar de la semana (es decir, el martes, lunes); pero, cuando usas "if (días % 7 == 0), estás comprobando el número par de la semana (domingo)
        


    }

    // Update is called once per frame
    void Update()//update y start se ejecutan automáticamente; el resto de métodos no lo hacen
    {
        //Debug.Log("Ha pasado un frame");//Este mensaje aparece porque, constantemente, esta función se actualiza
        //revive(3, "veneno");//este "metodo" se puede poner en el update, pero no es necesario.

        
        









    }
    int revive(int amenaza = 1, string estado = "nulo", int rondas = 0)//se ejecutará cuando lo llammes. Puedes declarar una variable local, la cual solo se usará en este método.
        //ten en cuenta que ES OBLIGATORIO poner a estas variables un dato o valor, puesto que, sin ellos, las variables locales no funcionan.
        
    {
        int carro = amenaza + rondas;
        return carro;// devuelve el valor de la variable "carro"a la variable del metodo "revive" (se puede poner la variable, por ejemplo, "int" en vez de "void")
        //

    }
}
