// The sample is adopted from: https://code-maze.com/dotnet-linq-improvements/
namespace LibraryApis.DotNet6;

public record Product(string Name, string Category, decimal Price);

public static class LinqImprovementsSample
{
    private static IEnumerable<Product> Products => new List<Product>
    {
        new("C# in Depth", "Book", 30),
        new("Software Architecture", "Book", 40),
        new("Design Patterns", "Book", 50),
        new("Lenovo X1 Carbon", "Hardware", 1500),
        new("Logitech G502", "Hardware", 150)
    };

    public static void Run()
    {
        const int pageSize = 2;
        var pagedListOfStudents = Products.Chunk(pageSize);
        Console.WriteLine(
            $"    Chunk - Products list page size: {pageSize}, number of pages: {pagedListOfStudents.Count()}");

        var minPriceProduct = Products.MinBy(x => x.Price)!;
        var maxPriceProduct = Products.MaxBy(x => x.Price)!;
        Console.WriteLine(
            $"    MinBy, MaxBy - Minimal price product: {minPriceProduct}; Maximum price product: {maxPriceProduct}");

        var defaultProduct = new Product("", "", -1);
        var matchedOrDefault = Products.FirstOrDefault(x => x.Name == "Not found", defaultProduct);
        Console.WriteLine($"    First/Last/SingleOrDefault - Product: {matchedOrDefault}");

        var secondToLast = Products.ElementAt(^2);
        Console.WriteLine($"    Indexing - Second from the end: {secondToLast}");

        var middle = Products.Take(1..^1);
        Console.WriteLine($"    Range - number of elements in the middle: {middle.Count()}");

        var categories = Products.DistinctBy(x => x.Category);
        Console.WriteLine(
            $"    Distinct/Except/Intersect/UnionBy - Number of distinct categories: {categories.Count()}");
    }
}
