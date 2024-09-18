using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Ejercicio_03 : MonoBehaviour
{
    [SerializeField] int HP = 0;
    [SerializeField] int Stamina = 0;
    [SerializeField] string name;
    [SerializeField] int Valor01;
    [SerializeField] int EXP;
    [SerializeField] float Radio;


    int LVL = 1;
    int Valor02;
    int Valor03;

    // Start is called before the first frame update
    void Start()
    {
        //EJERCICIO 3.1
        Debug.Log("Mana points: " + Stamina);
        Debug.Log("Health points: " + HP);
        Debug.Log("--------------------------------");
        //EJERCICIO 3.2
        Debug.Log("Bienvenido de nuevo, " +  name);
        Debug.Log("--------------------------------");
        //EJERCICIO 3.3
        Valor02 = Valor01 * 2;
        Valor03 = Valor01 * 3;
        Debug.Log("El doble de "+ Valor01 + " es " + Valor02);
        Debug.Log("El triple de " + Valor01 + " es " + Valor03);
        Debug.Log("--------------------------------");
        //EJERCICIO 3.4
        LVL = LVL +(9 * EXP / 5);
        Debug.Log("Has ganado " + EXP + " de experiencia");
        Debug.Log("¡Has subido de nivel!");
        Debug.Log("Ahora eres de nivel " + LVL);
        Debug.Log("--------------------------------");
        //EJERCICIO 3.5
        float LongitudDeCircunferencia;
        float AreaDeCircunferencia;
        LongitudDeCircunferencia = 2 * math.PI * Radio;
        AreaDeCircunferencia = math.PI * Radio / 2;
        Debug.Log("La longitud de alcance del enemigo es de " + LongitudDeCircunferencia);//problema: no se puede usar el símbolo ^ con float o int. Preguntar sobre su uso al profesor.
        Debug.Log("El área de alcance del enemigo es de " + AreaDeCircunferencia);
        Debug.Log("--------------------------------");
        //EJERCICIO 3.6

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
