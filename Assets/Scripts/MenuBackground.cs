using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBackground : MonoBehaviour
{
    [SerializeField] SpriteRenderer backgroundSpriteRenderer;
    [SerializeField] Sprite backgroundDay;
    [SerializeField] Sprite backgroundNight;

    void Start()
    {
        if (System.DateTime.Now.Hour >= 20 || System.DateTime.Now.Hour < 6)
        {
            backgroundSpriteRenderer.sprite = backgroundNight;
        }
        else
        {
            backgroundSpriteRenderer.sprite = backgroundDay;
        }
    }
}
