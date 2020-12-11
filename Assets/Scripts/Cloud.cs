using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : SwitchableObject
{
    // Start is called before the first frame update
    void Start()
    {
        type = "cloud";
        AddFunction(this);
    }

    public static void AddFunction(SwitchableObject so)
    {
        Rigidbody2D rb = so.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = -0.3f;
        rb.freezeRotation = true;
    }

    public static void RemoveFunction(SwitchableObject so)
    {
        DestroyImmediate(so.GetComponent<Rigidbody2D>());
    }
}
