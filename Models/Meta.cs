using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Meta
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("limit")]
    public required int Limit { get; init; }

    [JsonPropertyName("offset")]
    public required int Offset { get; init; }
}
