namespace LibraryApis.DotNet6;

public static class DateOnlyTimeOnlySample
{
    public static void Run()
    {
        var date = new DateOnly(2022, 10, 27);
        var time = new TimeOnly(11, 15);

        Console.WriteLine($"    The date is: {date}, the time is {time}");
    }
}
