namespace CSharp.Version11;

public static class ListAndStringPatternsSample
{
    public static void Run()
    {
        int[] one = { 1 };
        int[] odd = { 1, 3, 5 };
        int[] even = { 2, 4, 6 };

        Console.WriteLine($"    Odd array matches pattern: {odd is [1, 3, 5]}"); // true
        Console.WriteLine($"    Even array matches pattern: {even is [1, 3, 5]}"); // false (values)
        Console.WriteLine($"    One array matches pattern: {one is [1, 3, 5]}"); // false (length)

        Console.WriteLine($"    Odd array matches pattern: {odd is [1, .., 3, _]}"); // true
        Console.WriteLine($"    Even array matches pattern: {even is [2, _, 6, ..]}"); // true
        Console.WriteLine($"    One array matches pattern: {one is [1, ..]}"); // true

        Console.WriteLine($"    Odd array matches pattern: {odd is [_, > 1, ..]}"); // true
        Console.WriteLine($"    Even array matches pattern: {even is [_, > 1, ..]}"); // true
        Console.WriteLine($"    One array matches pattern: {one is [_, > 1, ..]}"); // false
    }
}
