using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{

    private float sekunden;
    private float delay;
    public float anfangswert;
    public float faktor;
    public float endwert;

    void Start()
    {
        delay = 1;
        endwert = anfangswert;

    }
    void Update()
    {
        
        sekunden += Time.deltaTime;

        if(sekunden >= delay)
        {
            delay++;
            endwert *= faktor;
        }
    }
}
