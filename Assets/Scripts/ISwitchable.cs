using UnityEngine;

public interface ISwitchable
{
    FunctionType FunctionType {get;}
    void AddFunction(Transform transform);
    void RemoveFunction(Transform transform);
}