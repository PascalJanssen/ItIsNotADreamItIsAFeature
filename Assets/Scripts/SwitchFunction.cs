using UnityEngine;
using UnityEngine.EventSystems;

public class SwitchFunction : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    protected SwitchableObject switchableObject;

    public void Switch(SwitchFunction otherFunction, FunctionType otherType)
    {
        otherFunction.BeforeSwitch();
        BeforeSwitch();

        otherFunction.switchableObject.functionType = switchableObject.functionType;
        switchableObject.functionType = otherType;

        otherFunction.switchableObject.switchableSprite.transform.parent = null;
        switchableObject.switchableSprite.transform.parent = null;

        otherFunction.transform.parent = switchableObject.transform;
        transform.parent = otherFunction.switchableObject.transform;

        otherFunction.transform.position = switchableObject.switchableSprite.transform.position;
        transform.position = otherFunction.switchableObject.switchableSprite.transform.position;

        otherFunction.switchableObject.switchableFunction = this;
        switchableObject.switchableFunction = otherFunction;

        otherFunction.switchableObject.switchableSprite.transform.parent = transform;
        switchableObject.switchableSprite.transform.parent = otherFunction.transform;

        otherFunction.switchableObject.switchableSprite.UpdateSprite(otherFunction.switchableObject.functionType);
        switchableObject.switchableSprite.UpdateSprite(otherType);

        otherFunction.switchableObject = otherFunction.GetComponentInParent<SwitchableObject>();
        switchableObject = GetComponentInParent<SwitchableObject>();

        otherFunction.AfterSwitch();
        AfterSwitch();
    }

    protected virtual void BeforeSwitch() { }

    protected virtual void AfterSwitch()
    {
        switchableObject = GetComponentInParent<SwitchableObject>();
    }

    public virtual void OnPointerDown(PointerEventData pointerEventData)
    {
        SwitchManager.Switch(switchableObject);
    }
}
