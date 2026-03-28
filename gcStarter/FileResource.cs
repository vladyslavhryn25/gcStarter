namespace gcStarter;
public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name) { }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"[File] Opening: {Name}");
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"[File] Closing: {Name}");
    }

    public void Dispose()
    {
        Console.WriteLine($"[File] Disposing: {Name}");
        Close();
    }
}