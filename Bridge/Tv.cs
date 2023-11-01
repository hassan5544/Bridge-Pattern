namespace Bridge;

public class Tv : IDevice
{
    public string VolumeUp()
    {
        return "Tv up";
    }

    public string VolumeDown()
    {
        return "Tv down";
    }

    public string Test()
    {
        throw new NotImplementedException();
    }
}