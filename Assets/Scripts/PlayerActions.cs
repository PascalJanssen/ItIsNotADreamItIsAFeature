using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D groundTrigger;
    private int triggerObjectCount = 0;
    private float speed = 8;
    private float jump = 17;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundTrigger = GetComponent<Player>().groundTrigger;
    }


    void FixedUpdate()
    {
        if(triggerObjectCount > 0 && Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
        Debug.Log(triggerObjectCount);
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, 0, 0));
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerObjectCount += 1;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        triggerObjectCount -= 1;
    }
}
