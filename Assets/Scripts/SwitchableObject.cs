using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchableObject : MonoBehaviour
{
    public string type = "";
    public SpriteRenderer renderer;
    public Sprite playerSprite;
    public Sprite stoneSprite;
    public Sprite cloudSprite;
    public Sprite metallSprite;
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
