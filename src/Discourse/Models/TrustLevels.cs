using System.Text.Json.Serialization;

namespace Discourse.Models;

public record TrustLevels
{
    [JsonPropertyName("newuser")]
    public required int Newuser { get; init; }

    [JsonPropertyName("basic")]
    public required int Basic { get; init; }

    [JsonPropertyName("member")]
    public required int Member { get; init; }

    [JsonPropertyName("regular")]
    public required int Regular { get; init; }

    [JsonPropertyName("leader")]
    public required int Leader { get; init; }
}
