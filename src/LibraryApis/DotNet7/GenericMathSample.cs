using System.Numerics;

namespace LibraryApis.DotNet7;

public static class GenericMathSample
{
    public static void Run()
    {
        var integers = new[] { 1, 5, 7, 3, 4, 2, 5 };
        var decimals = new[] { 1m, 5m, 7m, 3m, 4m, 2m, 5m };

        Console.WriteLine($"    Sum of integers: {Sum(integers)}");
        Console.WriteLine($"    Sum of decimals: {Sum(decimals)}");
    }

    // .NET 7
    private static T Sum<T>(IEnumerable<T> values) where T : INumber<T>
    {
        var result = T.Zero;

        foreach (var value in values)
        {
            result += value;
        }

        return result;
    }

    // .NET 6 and less
    //private static int Sum(IEnumerable<int> values)
    //{
    //    var result = 0;

    //    foreach (var value in values)
    //    {
    //        result += value;
    //    }

    //    return result;
    //}
    //private static decimal Sum(IEnumerable<decimal> values)
    //{
    //    var result = 0m;

    //    foreach (var value in values)
    //    {
    //        result += value;
    //    }

    //    return result;
    //}
}
