using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFunction : MonoBehaviour
{
    [SerializeField]
    protected SwitchableObject switchableObject;

    public void Switch(SwitchFunction function, FunctionType type)
    {
        function.BeforeSwitch();
        BeforeSwitch();

        function.switchableObject.functionType = switchableObject.functionType;
        switchableObject.functionType = type;

        function.switchableObject.switchableSprite.transform.parent = null;
        switchableObject.switchableSprite.transform.parent = null;

        function.transform.parent = switchableObject.transform;
        transform.parent = function.switchableObject.transform;

        function.transform.position = switchableObject.switchableSprite.transform.position;
        transform.position = function.switchableObject.switchableSprite.transform.position;

        function.switchableObject.switchableFunction = switchableObject.switchableFunction;
        switchableObject.switchableFunction = function;

        function.switchableObject.switchableSprite.transform.parent = transform;
        switchableObject.switchableSprite.transform.parent = function.transform;

        function.switchableObject.switchableSprite.UpdateSprite(function.switchableObject.functionType);
        switchableObject.switchableSprite.UpdateSprite(type);
        
        function.AfterSwitch();
        AfterSwitch();
    }

    protected virtual void BeforeSwitch(){ }

    protected virtual void AfterSwitch()
    {
        switchableObject = GetComponentInParent<SwitchableObject>();
    }

    protected virtual void OnMouseDown()
    {
        RaycastHit2D[] hits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        foreach (RaycastHit2D hit in hits)
        {
            if (hit.collider != null && !hit.collider.isTrigger)
            {
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                SwitchManager.Switch(switchableObject);
            }
        }
    }
}
