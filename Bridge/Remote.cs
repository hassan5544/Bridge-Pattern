namespace Bridge;

public class Remote
{
    private readonly IDevice _device;

    public Remote(IDevice device)
    {
        _device = device;
    }

    public virtual string ToggleVolumeUp()
    {
        return _device.VolumeUp();
    }
    
    public virtual string ToggleVolumeDown()
    {
        return _device.VolumeDown();
    }

    public virtual string Toggle()
    {
        return "_device.Test();";
    }
}