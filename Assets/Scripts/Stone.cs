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
        go.gameObject.AddComponent<Rigidbody2D>();
    }

    public static void RemoveFunction(SwitchableObject go)
    {
        Destroy(go.GetComponent<Rigidbody2D>());
    }
}
