using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fahrer : MonoBehaviour
{
    public string name;

    public Auto car;

    public void Update()
    {
        car.motor.isWorking = false;
        car.links_hinten.name = "Honda";
        car.links_hinten.isWorking = true;
        car.rechts_vorne.name = "Toyota";
        car.rechts_hinten.name = "Mitsubishi";
        car.rechts_hinten.isWorking = true;
        car.links_vorne.name = "Fiat";
    }
}
