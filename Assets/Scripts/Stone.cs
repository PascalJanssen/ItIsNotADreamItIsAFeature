using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : SwitchableObject
{
    private void Start()
    {
        AddFunction(this);
    }

    public static void AddFunction(SwitchableObject go)
    {
        Rigidbody2D rb = go.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1000;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 6;
    }

    public static void RemoveFunction(SwitchableObject go)
    {
        Destroy(go.GetComponent<Rigidbody2D>());
    }
}
