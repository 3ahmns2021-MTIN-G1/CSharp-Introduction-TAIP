using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleFunction : MonoBehaviour
{

    public void FunktionInStart()
    {
        ZusatzFunktion();
    }

    public void FunktionInUpdate()
    {

    }

    public void ZusatzFunktion()
    {

    }

    public void RechenFunktion(float a, float b, float c)
    {
        float ergebnis = (a + b * c) / c;
        print(ergebnis);
    }

    public void TextAusgabeFunktion(string a, string b)
    {
        string ausgabe = "Schönen Guten Tag " + a + ". " + b + ". " + "Bis Bald " + a + ".";
        print(ausgabe);
    }

    // Start is called before the first frame update
    void Start()
    {
        FunktionInStart();

        RechenFunktion(7, 7, 4);
        RechenFunktion(12, 12, 5);
        RechenFunktion(2, 2, 8);
        RechenFunktion(4, 4, 342);
        RechenFunktion(100, 100, 1);

        TextAusgabeFunktion("Herr Gruber","Text A");
        TextAusgabeFunktion("Herr Maier","Text B");
        TextAusgabeFunktion("Frau Forst","Text C");
    }

    // Update is called once per frame
    void Update()
    {
        FunktionInUpdate();
    }
}
