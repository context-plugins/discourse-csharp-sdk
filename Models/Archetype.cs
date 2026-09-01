using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Archetype
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("options")]
    public required IReadOnlyList<object> Options { get; init; }
}
