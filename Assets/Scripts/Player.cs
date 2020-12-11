using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public BoxCollider2D groundTrigger;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 4;
        rb.freezeRotation = true;

        gameObject.AddComponent<PlayerActions>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
