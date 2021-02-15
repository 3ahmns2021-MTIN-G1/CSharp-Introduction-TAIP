using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IFExercise : MonoBehaviour
{

    public Rigidbody rb;
    public BoxCollider bc;
    public VideoPlayer vp;
    
    void Update()
    {
        if(rb.mass > 5 && bc.center.y ==3 && vp.isLooping == true)
        {
            print("Die Bedingungen sind alle erfüllt!");
        }
    }
}
