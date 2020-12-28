using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rechner : MonoBehaviour
{
    //.......... Variablen ..........

    public float wertEins;
    public float wertZwei;

    public float addition;
    public float subtraktion;
    public float multiplikation;
    public string division;
    public string modulo;

    private readonly float divisionInt;


    //.......... Funktionen Deklaration ..........

    public string ModuloFunktion(float a, float b)
    {
        int aNew = Convert.ToInt32(a);
        int bNew = Convert.ToInt32(b);
        int c;
        int d;
        int e;

        if (bNew == 0)
        {
            return "Teilen durch Null nicht möglich";
          
        }

        else if (aNew == bNew)
        {
            return "0";
        }

        else if (bNew < 0)
        {
            return "Wert Zwei zu klein";
        }

       else if (aNew > bNew)
        {
            c = aNew / bNew;
            d = c * bNew;
            e = aNew - d;
          
            return e.ToString();
        }

        else
        {
            return "Wert Zwei zu groß";
        }
    }

    public string DivisionFunktion(float a, float b)
    {
        if (b != 0)
        {
            float c = a / b;
            return c.ToString();
        }

        else
        {
            return "Teilen durch Null nicht möglich";
        }
    }

    //.......... Funktionen Aufrufe ..........

    public void Update()
    {
        modulo = ModuloFunktion(wertEins, wertZwei);
        addition = wertEins + wertZwei;
        subtraktion = wertEins - wertZwei;
        multiplikation = wertEins * wertZwei;
        division = DivisionFunktion(wertEins, wertZwei);
    }
}