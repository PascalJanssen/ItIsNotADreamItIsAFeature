﻿using System;
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
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null && !hit.collider.isTrigger && !type.Equals("player"))
        {
            Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
            SwitchManager.Switch(this);
        }
    }
}
