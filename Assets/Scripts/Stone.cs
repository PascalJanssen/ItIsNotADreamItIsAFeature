public class Stone : SwitchableObject
{
    private void Awake()
    {
        switchableFunction = new StoneFunction();
        switchableFunction.AddFunction(transform);
    }
}
