namespace CSharp.Version11;

// This is a file-scoped type
file readonly struct Point
{
    public Point()
    {
        X = 10;
    }

    public int X { get; init; }
    public int Y { get; init; }
}

public static class AutoDefaultStructsSample
{
    public static void Run()
    {
        var point = new Point();

        Console.WriteLine("    Struct members are initialized to defaults");
        Console.WriteLine($"    Point: {point.X}, {point.Y}");
        Console.WriteLine($"    Type of Point: {typeof(Point).AssemblyQualifiedName}");
    }
}
