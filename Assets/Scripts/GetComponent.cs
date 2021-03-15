using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetComponent : MonoBehaviour
{
    public GameObject go;
    public Text ausgabe;

    public void getComponent()
    {
        print(go.GetComponent<Transform>());
    }
}
