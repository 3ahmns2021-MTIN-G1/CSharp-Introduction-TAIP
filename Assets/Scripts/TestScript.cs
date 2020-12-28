using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //......... Variablen Deklaration .........

    public Rechner rechner;

    public float floatVarOne;
    public float floatVarTwo;
    public string modulo;


//.......... Funktionen Aufruf ..........

    void Update()
    {
        modulo = rechner.ModuloFunktion(floatVarOne, floatVarTwo);   
    }
}
