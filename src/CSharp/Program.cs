// See https://aka.ms/new-console-template for more information

using CSharp.DotNet6;

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

Console.WriteLine();
Console.WriteLine("*** C# 11 FEATURES (.NET 7) ***");
