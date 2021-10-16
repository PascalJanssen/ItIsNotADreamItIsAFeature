using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchableObject : MonoBehaviour
{
    public Collider2D groundTrigger;
    public FunctionType functionType;

    public GameObject switchableFunction;
    public SwitchableSprite switchableSprite;

    public void Switch(GameObject function, FunctionType type)
    {
        functionType = type;

        switchableSprite.transform.parent = null;
        function.transform.parent = transform;
        switchableFunction = function;
        switchableSprite.transform.parent = function.transform;
        switchableSprite.UpdateSprite(functionType);
    }
}
