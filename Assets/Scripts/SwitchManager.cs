using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager
{
    public static SwitchableObject player;
    
    public static void Switch(SwitchableObject clickedObject)
    {
        GameObject playerFunction = player.switchableFunction;

        player.Switch(clickedObject.switchableFunction, clickedObject.functionType);
        clickedObject.Switch(playerFunction, FunctionType.Player);

        player = clickedObject;
    }

}
