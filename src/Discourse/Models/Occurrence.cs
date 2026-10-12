using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Occurrence
{
    [JsonPropertyName("starts_at")]
    public required string? StartsAt { get; init; }

    [JsonPropertyName("ends_at")]
    public required string? EndsAt { get; init; }
}
