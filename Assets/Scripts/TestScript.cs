using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject gameObjectVar;

    void Update()
    {
        Mathf.Abs(1.1f);                                // Gibt den absoluten Wert eines Floats aus
        Mathf.Approximately(1.1f, 2.2f);                // Vergeleicht 2 Werte ob sie ähnlich sind


        gameObjectVar.CompareTag("Tag");                // Vergeleicht ein Gameobject mit einem Tag
        GameObject.Find("Name");                        // Findet ein GameObject über seinen Namen

        Vector3.Angle(new Vector3(), new Vector3());    // Gibt den Winkel zwischen zwei Vectoren aus

    }
}
