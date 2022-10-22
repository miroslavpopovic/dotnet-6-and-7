using System.Text.RegularExpressions;

namespace LibraryApis.DotNet7;

public static partial class RegexImprovementsSample
{
    [GeneratedRegex("^[a-zA-Z0-9-]*$")]
    private static partial Regex AlphanumericRegex();

    public static void Run()
    {
        const string alphanumeric = "dotnet-7";
        const string specialCharacters = "c#-11";

        Console.WriteLine($"    Source generator, match alphanumeric: {AlphanumericRegex().IsMatch(alphanumeric)}");
        Console.WriteLine($"    Source generator, match special: {AlphanumericRegex().IsMatch(specialCharacters)}");
    }
}
