using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fahrer : MonoBehaviour
{
    public string nameVar;

    public Auto car;

    public void Update()
    {
        car.motor.isWorking = false;
        car.links_hinten.marke = "Honda";
        car.links_hinten.isWorking = true;
        car.rechts_vorne.marke = "Toyota";
        car.rechts_hinten.marke = "Mitsubishi";
        car.rechts_hinten.isWorking = true;
        car.links_vorne.marke = "Fiat";
    }
}
