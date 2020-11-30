using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uebung01 : MonoBehaviour
{
    public float floatVar;
    public int intVar;
    public bool boolVar;
    public string stringVar;
    public HingeJoint hingleJointVar;
    public SpriteRenderer spriteRendererVar;
    public AudioSource audioSourceVar;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hingleJointVar.massScale = floatVar;
        spriteRendererVar.sortingOrder = intVar;
        hingleJointVar.gameObject.name = stringVar;
        audioSourceVar.loop = boolVar;
    }
}
