using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchableSprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite playerSprite;
    public Sprite stoneSprite;
    public Sprite cloudSprite;
    public Sprite magnetSprite;
    public Sprite metalSprite;
    public Sprite woodSprite;

    public void UpdateSprite(FunctionType type)
    {
        switch (type)
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
}
