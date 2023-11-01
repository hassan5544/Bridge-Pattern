namespace Bridge;

public class AdvancedRemoteControl : Remote
{
    public AdvancedRemoteControl(IDevice device) : base(device)
    {
    }

    public override string ToggleVolumeDown()
    {
        return "Advanced" +  base.ToggleVolumeDown();
    }

    public override string ToggleVolumeUp()
    {
        return "Advanced" + base.ToggleVolumeUp();
    }

    public string Mute()
    {
        return "Mute";
    }
}