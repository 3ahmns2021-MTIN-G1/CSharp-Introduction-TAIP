using System.Collections;
using System.Collections.Generic;
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
        return a - d;
    }

    public void Update()
    {
        modulo = ModuloFunktion(wertEins, wertZwei);
    }
}