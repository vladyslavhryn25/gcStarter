namespace Task2;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"[Struct] X={X}, Y={Y}");
    }
}
