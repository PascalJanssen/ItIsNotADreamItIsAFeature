using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().mass = 1000;
        GetComponent<Rigidbody2D>().drag = 0;
        GetComponent<Rigidbody2D>().angularDrag = 0;
        GetComponent<Rigidbody2D>().gravityScale = 6;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
