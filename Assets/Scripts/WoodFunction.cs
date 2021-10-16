using UnityEngine;

public class WoodFunction : ISwitchable
{
    private FunctionType functionType = FunctionType.Wood;

    public FunctionType FunctionType { get => functionType; }

    public void AddFunction(Transform transform)
    {
        Rigidbody2D rb = transform.gameObject.AddComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb.freezeRotation = true;
        transform.gameObject.layer = 9;
        transform.gameObject.GetComponentInChildren<SpriteRenderer>().gameObject.layer = 9;
    }

    public void RemoveFunction(Transform transform)
    {
        Object.DestroyImmediate(transform.GetComponent<Rigidbody2D>());
        transform.gameObject.layer = 0;
        transform.gameObject.GetComponentInChildren<SpriteRenderer>().gameObject.layer = 0;
    }
}