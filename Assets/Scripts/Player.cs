using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int score;
    public string taste;
    public Rigidbody rb;
    public Vector3 jumpForce;
    public GameObject floor;
    public float sekunden;
    public Text timerAnzeige;
    public Text scoreAnzeige;
    private bool isCounting = false;
    public GameObject start;
    public GameObject ende;


    void Update()
    {
        timerAnzeige.text = Convert.ToInt32(sekunden).ToString() + " Sekunden";
        scoreAnzeige.text = Convert.ToInt32(score).ToString() + " Punkte";

        if (isCounting)
        {
            sekunden += Time.deltaTime;
        }
        
        if (Input.GetKeyDown(taste))
        {
            rb.AddForce(jumpForce);
        }
    }

    private void OnTriggerEnter(Collider x)
    {
        if (x.gameObject == start)
        {
            isCounting = true;
        }

        else if (x.gameObject == ende)
        {
            isCounting = false;
        }
    }
}
