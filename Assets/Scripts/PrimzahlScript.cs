using System;
using UnityEngine;
using UnityEngine.UI;

public class PrimzahlScript : MonoBehaviour
{
    private int eingabe;
    private int eingabeTemp;

    public InputField eingabeFeld;
    public Text ausgabeFeld;
    public Operationen operationen; 
     
    public void Update()
    {        
        if (eingabeFeld.text == "" || eingabeFeld.text == " ")
        {
            ausgabeFeld.text = "Bitte eine Zahl eingeben";
            return;
        }

        eingabe = int.Parse(eingabeFeld.text);
        eingabeTemp = eingabe;

        if (operationen.IsPrimzahl(eingabe) == true)
        {
            ausgabeFeld.text = eingabe.ToString() + " ist eine Primzahl";
        }

        else
        {
            while (operationen.IsPrimzahl(eingabeTemp) == false)
            {
                eingabeTemp++;
            }

            ausgabeFeld.text = eingabe.ToString() + " ist keine Primzahl" + Environment.NewLine + eingabeTemp.ToString() + " ist die nächst höhere Primzahl";
        }
    }
}