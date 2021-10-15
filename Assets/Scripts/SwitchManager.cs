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


        /*
        Debug.Log(clickedObject.type);
        Player.RemoveFunction(player);

        if (clickedObject.type.Equals("stone"))
        {
            Stone.RemoveFunction(clickedObject);
            Stone.AddFunction(player);
            player.renderer.sprite = player.stoneSprite;
        }
        else if (clickedObject.type.Equals("cloud"))
        {
            Cloud.RemoveFunction(clickedObject);
            Cloud.AddFunction(player);
            player.renderer.sprite = player.cloudSprite;
        }
        else if (clickedObject.type.Equals("magnet"))
        {
            Magnet.RemoveFunction(clickedObject);
            Magnet.AddFunction(player);
            player.renderer.sprite = player.magnetSprite;
        }
        else if (clickedObject.type.Equals("metal"))
        {
            Metal.RemoveFunction(clickedObject);
            Metal.AddFunction(player);
            player.renderer.sprite = player.metalSprite;
        }
        else if (clickedObject.type.Equals("wood"))
        {
            Wood.RemoveFunction(clickedObject);
            Wood.AddFunction(player);
            player.renderer.sprite = player.woodSprite;
        }
        else
        {
            return;
        }

        clickedObject.renderer.sprite = clickedObject.playerSprite;
        Player.AddFunction(clickedObject);

        player.type = clickedObject.type;
        clickedObject.type = "player";
        player = clickedObject;*/
    }

}
