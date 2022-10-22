using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibraryApis.DotNet7;

[JsonDerivedType(typeof(Shape), nameof(Shape))]
[JsonDerivedType(typeof(Rectangle), nameof(Rectangle))]
public record Shape(string Name, int X, int Y);

public record Rectangle(string Name, int X, int Y, int Width, int Height) : Shape(Name, X, Y);

public static class JsonPolymorphismSample
{
    public static void Run()
    {
        Shape shape = new Rectangle("My rectangle", 10, 10, 30, 20);
        var shapeJson = JsonSerializer.Serialize(shape);

        Console.WriteLine($"    Serialized derived type: {shapeJson}");

        var deserializedShape = JsonSerializer.Deserialize<Shape>(shapeJson);
        Console.WriteLine($"    Deserialized value: {deserializedShape}");
    }
}
