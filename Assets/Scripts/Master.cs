using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public float floatVarFirst;
    public float floatVarSekond;
    public Rigidbody rigidbodyVar;
    public bool boolVar;
    public BoxCollider boxColliderVar;
    

    void Update()
    {
        rigidbodyVar.mass = floatVarFirst + 20.0f;
        rigidbodyVar.useGravity = boolVar;
        rigidbodyVar.isKinematic = boolVar;
        boxColliderVar.isTrigger = boolVar;
        rigidbodyVar.angularDrag = floatVarFirst + 50.0f;
        rigidbodyVar.drag = floatVarFirst - floatVarSekond;
    }
}
