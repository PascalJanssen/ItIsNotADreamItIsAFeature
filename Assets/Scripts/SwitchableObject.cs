using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SwitchableObject : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite playerSprite;
    public Sprite stoneSprite;
    public Sprite cloudSprite;
    public Sprite magnetSprite;
    public Sprite metalSprite;
    public Sprite woodSprite;
    public Collider2D groundTrigger;
    
    public ISwitchable switchableFunction;

    public void UpdateSprite()
    {
        switch (switchableFunction.FunctionType)
        {
            case FunctionType.Magnet:
                spriteRenderer.sprite = magnetSprite;
                break;
            case FunctionType.Player:
                spriteRenderer.sprite = playerSprite;
                break;
            case FunctionType.Wood:
                spriteRenderer.sprite = woodSprite;
                break;
            case FunctionType.Cloud:
                spriteRenderer.sprite = cloudSprite;
                break;
            case FunctionType.Metal:
                spriteRenderer.sprite = metalSprite;
                break;
            case FunctionType.Stone:
                spriteRenderer.sprite = stoneSprite;
                break;
            default:
                break;
        }
    }

    private void OnMouseDown()
    {
        RaycastHit2D[] hits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        foreach (RaycastHit2D hit in hits)
        {
            if (hit.collider != null && !hit.collider.isTrigger && switchableFunction.FunctionType != FunctionType.Player)
            {
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                SwitchManager.Switch(this);
            }
        }
    }
}
