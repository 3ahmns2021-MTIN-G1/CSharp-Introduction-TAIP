// Bibliotheken / Asembly Referenz / Namespaces
using System.Collections;
using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;


// Deklaration einer Klasse

// public           -> access modifier (Zugriffsrechte) | keyword (vorreservierte Schlüsselwort)
// class            -> keyword zur Deklaration einer Klasse
// ExampleClass     -> identifier (Name der Klasse)
// : MonoBehaviour  -> Erstellen eine Unterklasse von MonoBehaviour
// {}               -> Scope/Wirkungsbereich (Was ist alles in der Klasse enthalten)
public class ExampleClass : UnityEngine.MonoBehaviour
{
    // Deklaration von Variablen
    // Variablen sind Container für Value (Werte) oder References (Verweise)

    // Variablentypen mit Werten
    // public           -> access modifier (Wer darf von außen auf die Variable zugreifen)
    // int              -> Variablentyp (In diesem Fall Integer - Ganze Zahl)
    // ganzeZahlVariable-> identifier (Name der Variable)
    // ;                -> Ende des Statements (Deklaration der Variable)

    // Zuweisungsoperator (assignment operator) ->   =  (Istgleichzeichen)
    // Beide Seiten des Zuweisungsoperators müssen den GLEICHEN TYP haben!!!
    public int ganzeZahlVariable = 6;   // Ganze Zahlen - Integer - Instanzvariable (innerhalb der ganzen Klasse gültig)
    public float gleitKommaVariable = 4.2f; // Gleitkommazahlen
    public string textVariable = "Hier kommt mein Text rein";             // Text
    public bool boolVariable = true;               // Binäre Entscheidung (Boolscher Wert) (true/false)


    // Variablentypen mit Referenzen
    public UnityEngine.Rigidbody rigidBodyVariable;
    public UnityEngine.BoxCollider boxColliderVariable;
    public UnityEngine.Transform transformVariable;
    public UnityEngine.GameObject x;
    public ExampleClass ec;
    public UnityEngine.UI.Button btnVariable;


    // Deklaration von Funktionen   (Was soll die Funktion machen)  - TEIL1

    // public                       -> access modifier (Wer darf die Funktion verwenden?)
    // void (kein Wert) / int / float / GameObject / Button   
    //                              -> return type (Gitb die Funktion einen Wert zurück)
    // TestFunktion                 -> identifier (Name der Funktion)
    // ()                           -> Parameterliste (In diesem Fall ist sie leer)
    // {}                           -> Scope / Geltungsbereich (Was ist in der Funktion enthalten)
    public void TestFunktion()
    {
        // Aufruf einer Funktion - TEIL2 (Wann soll die Funktion ausgeführt werden)
        // print            -> Name der Funktion
        // ()               -> Parameterliste mit Parametern
        // ;                -> Ende des Aufrufs

        print("Meine Nachricht an die Konsole");
        print("1");
        print("2");
        print("3");
        print("4");
    }

    // Automatisch von Unity aufgerufen im ersten Frame in der Szene. Bezieht sich aufs Objekt.
    public void Start()
    {
        TestFunktion();

        print("x");
        print("y");
        print("z");
    }

    public void Update()
    {
        //TestFunktion();
    }
}