using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public int wertigkeit;

    private void OnTriggerEnter(Collider x)
    {
        if (x.gameObject.CompareTag("Player"))
        {
            x.gameObject.GetComponent<Player>().score += wertigkeit;
            gameObject.SetActive(false);
        }
        
    }
}
