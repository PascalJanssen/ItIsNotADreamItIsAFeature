public class Cloud : SwitchableObject
{
    private void Awake()
    {
        switchableFunction = new CloudFunction();
        switchableFunction.AddFunction(transform);
    }
}
