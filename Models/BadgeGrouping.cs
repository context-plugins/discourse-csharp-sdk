using System.Text.Json.Serialization;

namespace Discourse.Models;

public record BadgeGrouping
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    [JsonPropertyName("position")]
    public required int Position { get; init; }

    [JsonPropertyName("system")]
    public required bool System { get; init; }
}
