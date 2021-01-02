using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operationen : MonoBehaviour
{

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

    public int BiggestIntInArray(int[] array)
    {
        int x = 0;

        foreach (int e in array)
        {
            if (e > x)
            {
                x = e;
            }
        }

        return x;
    }

    public bool IsPrimzahl(int a)
    {
        int[] nichtTeilbarDurch = { 2, 3, 5, 7 };

        foreach (int o in nichtTeilbarDurch)
        {
            if (a == o)
            {
                return true;
            }
        }

        int i = 2;

        while (i < BiggestIntInArray(nichtTeilbarDurch))
        {
            if (ModuloFunktion(a, i) == 0)
            {
                return false;
            }

            i++;
        }

        return true;
    }
}
