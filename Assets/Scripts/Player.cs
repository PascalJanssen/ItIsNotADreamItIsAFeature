using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : SwitchableObject
{
    private void Awake()
    {
        SwitchManager.player = this;
        switchableFunction = new PlayerFunction();
        switchableFunction.AddFunction(transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Goal" && switchableFunction.FunctionType == FunctionType.Player)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
