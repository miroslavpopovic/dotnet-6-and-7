using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace LibraryApis.DotNet7;

public record Customer
{
    public string Name { get; init; } = string.Empty;
    public decimal Discount { get; init; }
    public string Secret { get; init; } = string.Empty;
}

public static class JsonContractCustomizationSample
{
    private static readonly JsonSerializerOptions Options = new()
    {
        TypeInfoResolver = new DefaultJsonTypeInfoResolver
        {
            Modifiers =
            {
                (JsonTypeInfo jsonTypeInfo) =>
                {
                    // Modify reading and writing decimals
                    if (jsonTypeInfo.Type == typeof(decimal))
                    {
                        jsonTypeInfo.NumberHandling =
                            JsonNumberHandling.WriteAsString | JsonNumberHandling.AllowReadingFromString;
                    }

                    // Ignore some properties by name
                    if (jsonTypeInfo.Type == typeof(Customer))
                    {
                        var allowedProperties =
                            jsonTypeInfo.Properties.Where(pi => pi.Name != "Secret").ToArray();
                        jsonTypeInfo.Properties.Clear();
                        foreach (var property in allowedProperties)
                            jsonTypeInfo.Properties.Add(property);
                    }
                }
            }
        }
    };

    public static void Run()
    {
        var customer = new Customer { Name = "Test customer", Discount = 15.45m, Secret = "Hidden" };
        var json = JsonSerializer.Serialize(customer, Options);

        Console.WriteLine($"    Customer: {customer}");
        Console.WriteLine($"    Serialized customer: {json}");

        var deserialized = JsonSerializer.Deserialize<Customer>(json, Options);
        Console.WriteLine($"    Deserialized customer: {deserialized}");
    }
}
