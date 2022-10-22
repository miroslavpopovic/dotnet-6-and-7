namespace CSharp.Version11;

public static class RawStringLiteralsSample
{
    public static void Run()
    {
        const string oldJson = @"
           {
              ""Languages"": [
                { ""Name"": ""C#"" },
                { ""Name"": ""F#"" }
              ]
            }";

        const string json = """
            {
              "Languages": [
                { "Name": "C#" },
                { "Name": "F#" }
              ]
            }
            """;

        const string xml = """
            <Languages>
                <Language Name="C#" />
                <Language Name="F#" />
            </Persons>
            """;

        const int versionMajor = 11;
        const int versionMinor = 0;

        // Using interpolation with the new string literals
        var csharpVersion = $$"""
                "CSharp": {
                   "Version": "{{
                    // Using new line inside the "holes" of interpolated string
                    versionMajor +
                    "." +
                    versionMinor
                 }}"
                }
            """;

        Console.WriteLine($"    JSON with verbatim strings:\n{oldJson}");
        Console.WriteLine($"    JSON with raw string literals:\n{json}");
        Console.WriteLine($"    XML with raw string literals:\n{xml}");
        Console.WriteLine($"    CSharp version:\n{csharpVersion}");
    }
}
