public class Metal : SwitchableObject
{
    private void Awake()
    {
        switchableFunction = new MetalFunction();
        switchableFunction.AddFunction(transform);
    }
}
