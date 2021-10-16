using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager
{
    public static SwitchableObject player;
    
    public static void Switch(SwitchableObject clickedObject)
    {
        player.switchableFunction.Switch(clickedObject.switchableFunction, clickedObject.functionType);

        player = clickedObject;
    }

}
