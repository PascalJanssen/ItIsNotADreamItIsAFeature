using UnityEngine;

public class MagnetFunction : ISwitchable
{
    private FunctionType functionType = FunctionType.Magnet;

    public FunctionType FunctionType { get => functionType; }

    public void AddFunction(Transform transform)
    {
        transform.gameObject.layer = 10;

        Rigidbody2D rb = transform.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 10000;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 0;
        rb.freezeRotation = true;
        rb.sleepMode = RigidbodySleepMode2D.NeverSleep;

        CircleCollider2D cc = transform.gameObject.AddComponent<CircleCollider2D>();
        cc.isTrigger = true;
        cc.usedByEffector = true;
        cc.radius = 15;

        PointEffector2D pe = transform.gameObject.AddComponent<PointEffector2D>();
        pe.colliderMask = 1024;
        pe.forceMagnitude = -40000;
    }

    public void RemoveFunction(Transform transform)
    {
        transform.gameObject.layer = 0;

        Object.DestroyImmediate(transform.GetComponent<Rigidbody2D>());
        Object.DestroyImmediate(transform.GetComponent<CircleCollider2D>());
        Object.DestroyImmediate(transform.GetComponent<PointEffector2D>());
    }
}