using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SwitchableObject
{
    private void Start()
    {
        SwitchManager.player = this;
        AddFunction(this);
    }

    public static void AddFunction(SwitchableObject go)
    {
        Rigidbody2D rb = go.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 4;
        rb.freezeRotation = true;

        go.gameObject.AddComponent<PlayerActions>();
    }

    public static void RemoveFunction(SwitchableObject go)
    {
        Destroy(go.GetComponent<Rigidbody2D>());
        Destroy(go.GetComponent<PlayerActions>());
    }
}
