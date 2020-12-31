using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrimzahlScript : MonoBehaviour
{
    //.......... Variablen ..........

    private int eingabe;
    private string ausgabe;

    private int eingabeNeu;

    public Text text;
    public InputField inputField;

    //.......... Funktionen Deklaration ..........

    public int ModuloFunktion(int a, int b)
    {
        int c;
        int d;
        int e;

        c = a / b;
        d = c * b;
        e = a - d;

        return e;
    }

    public int PrimzahlRechner(int a)
    {
        if (a == 2)
        {
            return 1;
        }

        else if (a == 3)
        {
            return 1;
        }

        else if (a == 5)
        {
            return 1;
        }

        else if (a == 7)
        {
            return 1;
        }

        else if (ModuloFunktion(a,2) == 0)
        {
            return 0;
        }

        else if (ModuloFunktion(a,3) == 0)
        {
            return 0;
        }

        else if (ModuloFunktion(a,4) == 0)
        {
            return 0;
        }

        else if (ModuloFunktion(a,5) == 0)
        {
            return 0;
        }

        else if (ModuloFunktion(a,6) == 0)
        {
            return 0;
        }

        else if (ModuloFunktion(a,7) == 0)
        {
            return 0;
        }

        else if (ModuloFunktion(a,8) == 0)
        {
            return 0;
        }

        else if (ModuloFunktion(a,9) == 0)
        {
            return 0;
        }

        else
        {
            return 1;
        }
    }

    //.......... Funktionen Aufrufe ..........

    public void Update()
    {
        eingabe = int.Parse(inputField.text);
        eingabeNeu = eingabe;

        if (PrimzahlRechner(eingabe) == 1)
        {
            ausgabe = eingabe.ToString() + " ist eine Primzahl";
            text.text = ausgabe;
        }

        else
        {
            while(PrimzahlRechner(eingabeNeu) == 0)
            {
                eingabeNeu++;
            }

            ausgabe = eingabeNeu.ToString() + " ist die nächst höhere Primzahl";
            text.text = ausgabe;
        }
    }
}
