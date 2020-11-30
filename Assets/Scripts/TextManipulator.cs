using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManipulator : MonoBehaviour
{

    public Text textVar;
    public string textInhalt;
    public int textSize;
    public int textLineSpacing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textVar.text = textInhalt;
        textVar.fontSize = textSize;
        textVar.lineSpacing = textLineSpacing;
    }
}
