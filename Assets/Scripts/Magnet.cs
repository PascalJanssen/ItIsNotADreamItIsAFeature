using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : SwitchableObject
{
    private void Awake()
    {
        switchableFunction = new MagnetFunction();
        switchableFunction.AddFunction(transform);
    }
}
