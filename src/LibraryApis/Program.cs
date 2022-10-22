// See https://aka.ms/new-console-template for more information

using LibraryApis.DotNet6;
using LibraryApis.DotNet7;

Console.WriteLine("*** New and improved BCL APIs in .NET 6 ***");

Console.WriteLine("01. Logging source code generator");
LoggingSourceCodeGeneratorSample.Run();

Console.WriteLine("02. LINQ improvements");
LinqImprovementsSample.Run();

Console.WriteLine("03. DateOnly and TimeOnly");
DateOnlyTimeOnlySample.Run();

Console.WriteLine("04. Low-level file APIs");
await LowLevelFileApisSample.Run();

Console.WriteLine("05. Priority queue");
PriorityQueueSample.Run();

Console.WriteLine("06. JSON improvements");
await JsonImprovementsSample.Run();


Console.WriteLine();
Console.WriteLine("*** New and improved BCL APIs in .NET 7 ***");

Console.WriteLine("07. Generic Math");
GenericMathSample.Run();

Console.WriteLine("08. Regular expression improvements");
RegexImprovementsSample.Run();

Console.WriteLine("09. Microseconds and nanoseconds for time");
MicrosecondsNanosecondsSample.Run();

Console.WriteLine("10. JSON polymorphism");
JsonPolymorphismSample.Run();

Console.WriteLine("10. JSON contract customization");
JsonContractCustomizationSample.Run();
