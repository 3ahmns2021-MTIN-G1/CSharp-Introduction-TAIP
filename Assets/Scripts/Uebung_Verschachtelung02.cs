using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uebung_Verschachtelung02 : MonoBehaviour
{
     void Update()
    {
        // # 1

        // GameObject.Find("Directional Light")                                              // GameObject
        // GameObject.Find("Directional Light").active                                       // true
        // GameObject.Find("Directional Light").active.ToString()                            // "true"
        // GameObject.Find("Directional Light").active.ToString().Length                     // 4

        int x = GameObject.Find("Directional Light").active.ToString().Length;
        Debug.Log(x);


        // # 2

        // GameObject.Find("GameObject")                                                    // GameObject
        // GameObject.Find("GameObject").transform                                          // Component
        // GameObject.Find("GameObject").transform.position                                 // Vector3
        // GameObject.Find("GameObject").transform.position.x                               // 498.8463
        // GameObject.Find("GameObject").transform.position.x.ToString()                    // "498.8463"

        string y = GameObject.Find("GameObject").transform.position.x.ToString();
        Debug.Log(y);


        // # 3

        // GameObject.Find("Cube")                                                          // GameObject
        // GameObject.Find("Cube").GetComponent<MeshRenderer>()                             // Component
        // GameObject.Find("Cube").GetComponent<MeshRenderer>().receiveShadows;             // true

        bool z = GameObject.Find("Cube").GetComponent<MeshRenderer>().receiveShadows;
        Debug.Log(z);


        // # 4

        // GameObject.Find("Cube")                                                          // GameObject
        // GameObject.Find("Cube").transform                                                // Component
        // GameObject.Find("Cube").transform.position                                       // Vector3
        // GameObject.Find("Cube").transform.position.x                                     // 498.8463
        // Convert.ToInt32(GameObject.Find("Cube").transform.position.x                     // 499

        int w = Convert.ToInt32(GameObject.Find("Cube").transform.position.x);
        Debug.Log(w);
    }

}
