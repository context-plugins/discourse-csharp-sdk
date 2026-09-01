using System.Text.Json.Serialization;

namespace Discourse.Models;

public record TagGroupsJsonRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
