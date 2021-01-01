using System;
using UnityEngine;
using UnityEngine.UI;

public class PrimzahlScript : MonoBehaviour
{
    //.......... Variablen Deklaration ..........

    private int eingabe;
    private int eingabeTemp;

    public int[] teilbarDurch;

    public InputField eingabeFeld;
    public Text ausgabeFeld;
    

    //.......... Funktionen Deklaration ..........

    public int ModuloFunktion(int a, int b)
    {
        if (a > b)
        {
            int c = a / b;
            int d = c * b;

            return a - d;
        }

        else
        {
            return 0;
        }
    }

    public bool IsPrimzahl(int a)
    {
        foreach (int i in teilbarDurch)
        {
           if (a == i)
           {
                return true;
           }
        }

        for (int i = 2; i < 7; i++)
        {
           if (ModuloFunktion(a, i) == 0)
           {
                return false;
           }
        }

        return true;
    }

    //.......... Funktionen Aufrufe ..........

    public void Update()
    {
        if (eingabeFeld.text == "")
        {
            ausgabeFeld.text = "Bitte eine Zahl eingeben";
            return;
        }

        eingabe = int.Parse(eingabeFeld.text);
        eingabeTemp = eingabe;

        if (IsPrimzahl(eingabe) == true)
        {
            ausgabeFeld.text = eingabe.ToString() + " ist eine Primzahl";
        }

        else
        {
            while (IsPrimzahl(eingabeTemp) == false)
            {
                eingabeTemp++;
            }

            ausgabeFeld.text = eingabe.ToString() + " ist keine Primzahl" + Environment.NewLine + eingabeTemp.ToString() + " ist die nächst höhere Primzahl";
        }
    }
}