using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : SwitchableObject
{
    private void Awake()
    {
        SwitchManager.player = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Goal" && functionType == FunctionType.Player)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
