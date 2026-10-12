using System.Text.Json.Serialization;

namespace Discourse.Models;

public record CategoryType
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("icon")]
    public required string Icon { get; init; }

    [JsonPropertyName("available")]
    public required bool Available { get; init; }

    [JsonPropertyName("visible")]
    public required bool Visible { get; init; }

    [JsonPropertyName("configuration_schema")]
    public required object ConfigurationSchema { get; init; }
}
