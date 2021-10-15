using UnityEngine;

public class CloudFunction : ISwitchable
{
    private FunctionType functionType = FunctionType.Cloud;

    public FunctionType FunctionType { get => functionType; }

    public void AddFunction(Transform transform)
    {
        transform.gameObject.layer = 8;
        transform.gameObject.GetComponentInChildren<SpriteRenderer>().gameObject.layer = 8;

        Rigidbody2D rb = transform.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = -0.3f;
        rb.freezeRotation = true;
    }

    public void RemoveFunction(Transform transform)
    {
        transform.gameObject.layer = 0;
        transform.gameObject.GetComponentInChildren<SpriteRenderer>().gameObject.layer = 0;

        Object.DestroyImmediate(transform.GetComponent<Rigidbody2D>());
    }
}