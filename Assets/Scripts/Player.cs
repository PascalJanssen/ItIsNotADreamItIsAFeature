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
        Debug.Log("RED");
    }

    public static void RemoveFunction(SwitchableObject go)
    {
    }
}
