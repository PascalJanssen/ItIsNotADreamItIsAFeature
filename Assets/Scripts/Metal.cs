using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : SwitchableObject
{
    private void Start()
    {
        type = "metal";
        AddFunction(this);
    }

    public static void AddFunction(SwitchableObject so)
    {
        Rigidbody2D rb = so.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 10000;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 6;
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb.freezeRotation = true;

        CircleCollider2D cc = so.gameObject.AddComponent<CircleCollider2D>();
        cc.isTrigger = true;
        cc.usedByEffector = true;
        cc.radius = 0.25f;

        PointEffector2D pe = so.gameObject.AddComponent<PointEffector2D>();
        pe.colliderMask = 1024;
        pe.forceMagnitude = -40000;
    }

    public static void RemoveFunction(SwitchableObject so)
    {
        DestroyImmediate(so.GetComponent<Rigidbody2D>());
        DestroyImmediate(so.GetComponent<CircleCollider2D>());
        DestroyImmediate(so.GetComponent<PointEffector2D>());
    }
}
