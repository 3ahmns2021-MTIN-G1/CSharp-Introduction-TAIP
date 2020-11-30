using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UebungVerschachtelung : MonoBehaviour
{

    public GameObject go;
    public float yPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yPosition = go.transform.position.y;
    }
}
