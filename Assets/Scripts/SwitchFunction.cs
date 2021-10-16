using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFunction : MonoBehaviour
{
    SwitchableObject switchableObject;

    private void OnMouseDown()
    {
        switchableObject = GetComponentInParent<SwitchableObject>();
        RaycastHit2D[] hits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        foreach (RaycastHit2D hit in hits)
        {
            if (hit.collider != null && !hit.collider.isTrigger && switchableObject.functionType != FunctionType.Player)
            {
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                SwitchManager.Switch(switchableObject);
            }
        }
    }
}
