namespace CSharp.DotNet6;

public static class InterpolatedStringSample
{
    public static void Run()
    {
        const string personName = "Miroslav";
        const string personalizedMessage = $"Hello, {personName}";

        Console.WriteLine($"    Interpolated strings can be constants - {personalizedMessage}");
    }
}
