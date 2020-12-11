using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : SwitchableObject
{
    private void Start()
    {
        AddFunction(this);
    }

    public static void AddFunction(SwitchableObject so)
    {
        Rigidbody2D rb = so.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1000;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 6;
        rb.freezeRotation = true;
    }

    public static void RemoveFunction(SwitchableObject so)
    {
        DestroyImmediate(so.GetComponent<Rigidbody2D>());
    }
}
