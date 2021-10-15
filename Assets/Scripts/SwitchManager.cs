using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager
{
    public static SwitchableObject player;

    public static void Switch(SwitchableObject clickedObject)
    {

        player.switchableFunction.RemoveFunction(player.transform);
        clickedObject.switchableFunction.RemoveFunction(clickedObject.transform);

        clickedObject.switchableFunction.AddFunction(player.transform);
        player.switchableFunction.AddFunction(clickedObject.transform);
        
        player.switchableFunction = clickedObject.switchableFunction;
        clickedObject.switchableFunction = new PlayerFunction();

        player.UpdateSprite();
        clickedObject.UpdateSprite();

        player = clickedObject;
    }

}
