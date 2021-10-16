using Sirenix.OdinInspector;
using UnityEngine;

public class MagnetFunction : SwitchFunction
{
    [SerializeField]
    private int magnetLayer = 10;
    [SerializeField, Required]
    private new Rigidbody2D rigidbody2D;

    protected override void BeforeSwitch()
    {
        base.BeforeSwitch();

        transform.gameObject.layer = 0;

        foreach (Transform child in transform)
        {
            child.gameObject.layer = 0;
        }

        rigidbody2D.velocity = Vector2.zero;
    }

    protected override void AfterSwitch()
    {
        base.AfterSwitch();

        transform.gameObject.layer = magnetLayer;
        foreach (Transform child in transform)
        {
            child.gameObject.layer = magnetLayer;
        }
    }
}