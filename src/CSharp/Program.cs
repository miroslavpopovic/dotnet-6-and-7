// See https://aka.ms/new-console-template for more information

using CSharp.Version10;
using CSharp.Version11;

// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10
Console.WriteLine("*** C# 10 FEATURES (.NET 6) ***");

Console.WriteLine("01. Global using and implicit global using");
var match = new Regex("[0-9]{2}").Match("12345");
Console.WriteLine($"    Global using support: {(match.Success ? "Yes" : "No")}");

Console.WriteLine("02. File scoped namespaces - check other classes in the project");

Console.WriteLine("03. Record structs and parameterless constructors");
RecordStructsSample.Run();

Console.WriteLine("04. Extended property pattern");
PropertyPatternsSample.Run();

Console.WriteLine("05. Constant interpolated strings");
InterpolatedStringSample.Run();

// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11
Console.WriteLine();
Console.WriteLine("*** C# 11 FEATURES (.NET 7) ***");

Console.WriteLine("06. Raw string literals and interpolation improvements");
RawStringLiteralsSample.Run();

Console.WriteLine("07. Generic attributes");
GenericAttributesSample.Run();

Console.WriteLine("08. Auto-default structs and file-scoped types");
AutoDefaultStructsSample.Run();

Console.WriteLine("09. List and string patterns");
ListAndStringPatternsSample.Run();

Console.WriteLine("10. Required members");
RequiredMembersSample.Run();
