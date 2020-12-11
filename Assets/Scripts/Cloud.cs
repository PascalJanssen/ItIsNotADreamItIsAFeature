using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : SwitchableObject
{
    private void Start()
    {
        type = "cloud";
        AddFunction(this);
    }

    public static void AddFunction(SwitchableObject so)
    {
        so.gameObject.layer = 8;
        so.gameObject.GetComponentInChildren<SpriteRenderer>().gameObject.layer = 8;

        Rigidbody2D rb = so.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = -0.3f;
        rb.freezeRotation = true;
    }

    public static void RemoveFunction(SwitchableObject so)
    {
        so.gameObject.layer = 0;
        so.gameObject.GetComponentInChildren<SpriteRenderer>().gameObject.layer = 0;

        DestroyImmediate(so.GetComponent<Rigidbody2D>());
    }
}
