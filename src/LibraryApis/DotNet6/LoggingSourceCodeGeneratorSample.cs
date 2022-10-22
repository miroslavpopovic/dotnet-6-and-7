// The sample is adopted from: https://steven-giesel.com/blogPost/48697958-4aee-474a-8920-e266d1d7b8fa
using Microsoft.Extensions.Logging;

namespace LibraryApis.DotNet6;

public record InventoryProduct(string Name, decimal Price);

public partial class InventoryService
{
    private readonly ILogger _logger;

    public InventoryService(ILogger logger)
    {
        _logger = logger;
    }

    public void AddProduct(InventoryProduct product)
    {
        LogAddProduct(product, DateTime.UtcNow);
        // Save product here...
    }

    [LoggerMessage(Message = "Creating product: {product} at {timestamp}", Level = LogLevel.Information, EventId = 1)]
    private partial void LogAddProduct(InventoryProduct product, DateTime timestamp);
}

public static class LoggingSourceCodeGeneratorSample
{
    public static void Run()
    {
        var logger = LoggerFactory.Create(log => log.AddConsole()).CreateLogger(typeof(InventoryService));
        var inventoryService = new InventoryService(logger);
        var product = new InventoryProduct("C# in Depth", 30);

        inventoryService.AddProduct(product);
    }
}
