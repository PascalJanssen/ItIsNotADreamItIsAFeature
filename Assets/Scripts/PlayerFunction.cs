using UnityEngine;

public class PlayerFunction : ISwitchable
{
    private FunctionType functionType = FunctionType.Player;

    public FunctionType FunctionType { get => functionType;}

    public void AddFunction(Transform transform)
    {
        Rigidbody2D rb = transform.gameObject.AddComponent<Rigidbody2D>();
        rb.mass = 1;
        rb.drag = 0;
        rb.angularDrag = 0;
        rb.gravityScale = 4;
        rb.freezeRotation = true;

        transform.gameObject.AddComponent<PlayerActions>();
    }

    public void RemoveFunction(Transform transform)
    {
        Object.DestroyImmediate(transform.GetComponent<PlayerActions>());
        Object.DestroyImmediate(transform.GetComponent<Rigidbody2D>());
    }
}