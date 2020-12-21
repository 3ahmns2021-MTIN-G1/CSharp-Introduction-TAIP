//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Modulo : MonoBehaviour
{
    public int wertEins;
    public int wertZwei;
    public int modulo;

    public int ModuloFunktion(int a, int b)
    {
        int c = a / b;
        int d = c * b;
        int e = a - d;
        return e;
    }

    public void Update()
    {
        modulo = ModuloFunktion(wertEins, wertZwei);
    }
}