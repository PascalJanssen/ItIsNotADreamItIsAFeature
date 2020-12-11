using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager
{
    public static SwitchableObject player;

    public static void Switch(SwitchableObject clickedObject)
    {
        Debug.Log(clickedObject.type);
        if (clickedObject.type.Equals("stone"))
        {
            Player.RemoveFunction(player);
            Stone.RemoveFunction(clickedObject);
            Stone.AddFunction(player);
            clickedObject.renderer.sprite = clickedObject.playerSprite;
            player.renderer.sprite = clickedObject.stoneSprite;
        }
        else if (clickedObject.type.Equals("cloud"))
        {

        }
        else
        {
            return;
        }

        Player.AddFunction(clickedObject);

        player.type = clickedObject.type;
        clickedObject.type = "player";
        player = clickedObject;
    }

}
