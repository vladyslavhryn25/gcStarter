namespace gcStarter;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name) { }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"[Network] Opening: {Name}");
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"[Network] Closing: {Name}");
    }

    public void Dispose()
    {
        Console.WriteLine($"[Network] Disposing: {Name}");
        Close();
    }
}