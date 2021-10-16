using UnityEngine;

public class CloudFunction : SwitchFunction
{
    [SerializeField]
    private int cloudLayer = 8;

    protected override void BeforeSwitch()
    {
        base.BeforeSwitch();

        transform.gameObject.layer = 0;

        foreach (Transform child in transform)
        {
            child.gameObject.layer = 0;
        }
    }

    protected override void AfterSwitch()
    {
        base.AfterSwitch();

        transform.gameObject.layer = cloudLayer;

        foreach (Transform child in transform)
        {
            child.gameObject.layer = cloudLayer;
        }
    }
}