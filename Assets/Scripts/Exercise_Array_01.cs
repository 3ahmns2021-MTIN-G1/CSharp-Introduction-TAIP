using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_Array_01 : MonoBehaviour
{
    // 1. Declare an array of integers with 4 values
    public int[] intArray = new int[4];

    // 2. Declare an array of strings with 3 values
    public string[] stringArray = new string[3];

    // 3. Declare an array of GameObjects with 5 values
    public GameObject[] gameObjectArray = new GameObject[5];

    // 4. Declare an array of Rigidbodies with 2 values
    public Rigidbody[] rigidbodyArray = new Rigidbody[4];

    private int value;
    public int n;
    public int[] multipleTwo;
    public int[] fibo = { 0, 1 };
    public string[] names = { "a", "b", "c", "e", "f", "g" };

    void Start()
    {
        
        // Arrays mit Loops
        // 5. In den Elementen des Arrays soll das vielfache von 2 stehen. -> [2,4,6,8,10,....,n].
        for (int i = 0; i < n; i++)
        {
            value += 2;
            multipleTwo[i] = value;
        }

        // 6. Es soll ein zufälliges Element auf der Console ausgegeben werden
        print(names[Random.Range(0, names.Length)]);


        //// 7. Fibonacci Folge -> [0,1,1,2,3,5,8,13,21,...,n]
        for (int i = 0; i < n; i++)
        {
            if (i > 2)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
        }
    }
}
