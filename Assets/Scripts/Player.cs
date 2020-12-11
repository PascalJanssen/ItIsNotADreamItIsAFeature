using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : SwitchableObject
{
    private void Start()
    {
        type = "player";
        SwitchManager.player = this;
        AddFunction(this);
    }

    public static void AddFunction(SwitchableObject so)
    {
        Rigidbody2D rb = so.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 4;
        rb.freezeRotation = true;

        so.gameObject.AddComponent<PlayerActions>();
    }

    public static void RemoveFunction(SwitchableObject so)
    {
        DestroyImmediate(so.GetComponent<PlayerActions>());
        DestroyImmediate(so.GetComponent<Rigidbody2D>());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Goal")
        {
            SceneManager.LoadScene("Victory");        }
    }
}
