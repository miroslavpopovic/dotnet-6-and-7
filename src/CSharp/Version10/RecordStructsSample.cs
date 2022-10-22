namespace CSharp.Version10;

public readonly record struct Point(double X, double Y);

public record struct Rectangle(Point TopLeft, Point BottomRight);

public readonly record struct Circle
{
    // New C# 10 feature - parameterless struct constructors and field initializers
    public Circle()
    {
        Center = new Point(1, 1);
        Radius = Math.Abs(Center.X - 1) < 0.01 ? 10 : 20;
    }

    public Point Center { get; init; }
    public double Radius { get; init; }
}

public static class RecordStructsSample
{
    public static void Run()
    {
        var rectangle = new Rectangle(new Point(5, 5), new Point(10, 20));

        // Rectangle struct is not readonly, we can change properties
        rectangle.BottomRight = new Point(20, 30);

        // However, we cannot change the properties on Point, as it's readonly, and properties are init
        // rectangle.BottomRight.X = 12;

        var circle = new Circle { Center = new Point(10, 10), Radius = 20 };
        // init only properties, cannot change
        // circle.Center = new Point(15, 15);
        // circle.Radius = 30;

        var circle2 = circle with { Radius = 30 };

        Console.WriteLine("    Rectangle: " + rectangle.TopLeft + ", " + rectangle.BottomRight);
        Console.WriteLine("    Circle 1: Center = " + circle.Center + ", Radius = " + circle.Radius);
        Console.WriteLine("    Circle 2: Center = " + circle2.Center + ", Radius = " + circle2.Radius);
    }
}
