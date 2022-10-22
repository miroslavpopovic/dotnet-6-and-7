namespace LibraryApis.DotNet7;

public static class MicrosecondsNanosecondsSample
{
    public static void Run()
    {
        var time = new TimeOnly(11, 25, 44, 398, 843);
        var current = DateTime.Now;

        Console.WriteLine($"    Time microsecond: {time.Microsecond}");
        Console.WriteLine($"    Time nanosecond: {time.Nanosecond}");

        Console.WriteLine($"    Current time microsecond: {current.Microsecond}");
        Console.WriteLine($"    Current time nanosecond: {current.Nanosecond}");
    }
}
