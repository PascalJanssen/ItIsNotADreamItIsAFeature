public class Player : SwitchableObject
{
    private void Awake()
    {
        SwitchManager.player = this;
    }
}
