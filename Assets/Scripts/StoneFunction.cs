using UnityEngine;

public class StoneFunction : ISwitchable
{
    private FunctionType functionType = FunctionType.Stone;

    public FunctionType FunctionType { get => functionType; }

    public void AddFunction(Transform transform)
    {
        Rigidbody2D rb = transform.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1000;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 6;
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb.freezeRotation = true;
    }

    public void RemoveFunction(Transform transform)
    {
        Object.DestroyImmediate(transform.GetComponent<Rigidbody2D>());
    }
}