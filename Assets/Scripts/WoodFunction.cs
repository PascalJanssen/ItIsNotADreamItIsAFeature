using UnityEngine;

public class WoodFunction : SwitchFunction
{
    [SerializeField]
    private int woodLayer = 9;

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

        transform.gameObject.layer = woodLayer;

        foreach (Transform child in transform)
        {
            child.gameObject.layer = woodLayer;
        }
    }
}