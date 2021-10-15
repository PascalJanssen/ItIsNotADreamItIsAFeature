public class Wood : SwitchableObject
{
    private void Awake()
    {
        switchableFunction = new WoodFunction();
        switchableFunction.AddFunction(transform);
    }
}
