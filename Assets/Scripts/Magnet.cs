using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : SwitchableObject
{
    private void Start()
    {
        type = "magnet";
        AddFunction(this);
    }

    public static void AddFunction(SwitchableObject so)
    {
        so.gameObject.layer = 10;

        Rigidbody2D rb = so.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 10000;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 0;
        rb.freezeRotation = true;
        rb.sleepMode = RigidbodySleepMode2D.NeverSleep;

        CircleCollider2D cc = so.gameObject.AddComponent<CircleCollider2D>();
        cc.isTrigger = true;
        cc.usedByEffector = true;
        cc.radius = 15;

        PointEffector2D pe = so.gameObject.AddComponent<PointEffector2D>();
        pe.colliderMask = 1024;
        pe.forceMagnitude = -40000;

    }

    public static void RemoveFunction(SwitchableObject so)
    {
        so.gameObject.layer = 0;

        DestroyImmediate(so.GetComponent<Rigidbody2D>());
        DestroyImmediate(so.GetComponent<CircleCollider2D>());
        DestroyImmediate(so.GetComponent<PointEffector2D>());
    }
}
