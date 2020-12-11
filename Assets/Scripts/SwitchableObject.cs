using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchableObject : MonoBehaviour
{
    [HideInInspector]
    public string type = "";
    public SpriteRenderer renderer;
    public Sprite playerSprite;
    public Sprite stoneSprite;
    public Sprite cloudSprite;
    public Sprite magnetSprite;
    public Sprite metalSprite;
    public Sprite woodSprite;
    public Collider2D groundTrigger;

    private void OnMouseDown()
    {
        if (!type.Equals("player"))
        {
            SwitchManager.Switch(this);
        }
    }
}
