﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private Rigidbody2D rb;
    private int triggerObjectCount = 0;
    private float speed = 8;
    private float jumpPower = 20;
    private bool jumpButtonDown = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if(Input.GetAxis("Vertical") == 0)
        {
            jumpButtonDown = false;
        }

        if(!jumpButtonDown && triggerObjectCount > 0 && Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
            jumpButtonDown = true;
        }
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, 0, 0));
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (!other.isTrigger)
        {
            triggerObjectCount += 1;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.isTrigger)
        {
            triggerObjectCount -= 1;
        }
    }
}
