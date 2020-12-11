using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : SwitchableObject
{
    private void Start()
    {
        type = "wood";
        AddFunction(this);
    }

    public static void AddFunction(SwitchableObject so)
    {
        Rigidbody2D rb = so.gameObject.AddComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb.freezeRotation = true;
        so.gameObject.layer = 9;
    }

    public static void RemoveFunction(SwitchableObject so)
    {
        DestroyImmediate(so.GetComponent<Rigidbody2D>());
        so.gameObject.layer = 0;
    }
}
