namespace CSharp.Version11;

// Up to C# 10
public class TypeAttribute : Attribute
{
    public TypeAttribute(Type type) => Type = type;
    public Type Type { get; }
}

// C# 11
public class GenericTypeAttribute<T> : Attribute { }

[Type(typeof(string))]
[GenericType<string>]
public class AttributedClass { }

public static class GenericAttributesSample
{
    public static void Run()
    {
        var attributes = string.Join(
            ", ", typeof(AttributedClass).GetCustomAttributes(false).Select(x => x.GetType().Name));
        Console.WriteLine("    Attributes applied to the class: " + attributes);
    }
}
