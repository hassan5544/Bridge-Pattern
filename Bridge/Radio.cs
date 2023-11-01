namespace Bridge;

public class Radio : IDevice
{
    public string VolumeUp()
    {
        return "radio up";
    }

    public string VolumeDown()
    {
        return "radio down";
    }

    public string Test()
    {
        throw new NotImplementedException();
    }
}