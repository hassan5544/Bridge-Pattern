using Bridge;

class  Prgrame
{
    public static void Main()
    {
        Radio radio = new Radio();
        Remote remote;

        remote = new Remote(radio);
        Console.WriteLine(remote.ToggleVolumeUp());
        Console.WriteLine(remote.ToggleVolumeDown());
        Console.WriteLine(remote.Toggle());

        Tv tv = new Tv();
        
        
        remote = new AdvancedRemoteControl(tv);
        
        Console.WriteLine(remote.ToggleVolumeUp());
        Console.WriteLine(remote.ToggleVolumeDown());
        Console.WriteLine(remote.Toggle());

        AdvancedRemoteControl advancedRemoteControl = new AdvancedRemoteControl(tv);
        advancedRemoteControl.Mute();
    }
}