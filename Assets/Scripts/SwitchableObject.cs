using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchableObject : MonoBehaviour
{
    public Collider2D groundTrigger;
    public FunctionType functionType;

    public SwitchFunction switchableFunction;
    public SwitchableSprite switchableSprite;
}
