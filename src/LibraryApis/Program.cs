// See https://aka.ms/new-console-template for more information

using LibraryApis.DotNet6;

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


Console.WriteLine("*** New and improved BCL APIs in .NET 7 ***");

