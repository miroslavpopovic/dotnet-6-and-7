using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibraryApis.DotNet6;

public record CatFact(string Fact) : IJsonOnDeserialized, IJsonOnDeserializing
{
    public void OnDeserialized()
    {
        Console.WriteLine($"    deserialized - fact: {Fact}");
    }

    public void OnDeserializing()
    {
        Console.WriteLine($"    deserializing - fact: {Fact}");
    }
}

public record BoardGame
{
    // We can now modify the order of properties during serialization
    [JsonPropertyOrder(3)] public string Description { get; set; } = string.Empty;
    [JsonPropertyOrder(1)] public string Name { get; set; } = string.Empty;
    [JsonPropertyOrder(2)] public decimal Rating { get; set; }
}

[JsonSerializable(typeof(BoardGame))]
public partial class BoardGameJsonContext : JsonSerializerContext {}

public static class JsonImprovementsSample
{
    public static async Task Run()
    {
        var client = new HttpClient { BaseAddress = new Uri("https://catfact.ninja/") };
        var response = await client.GetFromJsonAsync<CatFact>("fact");

        Console.WriteLine($"    HttpClient extensions - random cat fact: {response!.Fact}");

        var boardGame = new BoardGame
        {
            Description = "A good family-friendly game",
            Name = "Ticket to Ride: Europe",
            Rating = 8.2m
        };

        var json = JsonSerializer.Serialize(boardGame, BoardGameJsonContext.Default.BoardGame);
        Console.WriteLine($"    Serialized JSON with source generators: {json}");

        var boardGameDeserialized = JsonSerializer.Deserialize(json, BoardGameJsonContext.Default.BoardGame);
        Console.WriteLine($"    Deserialized with source generators: {boardGameDeserialized}");
    }
}
