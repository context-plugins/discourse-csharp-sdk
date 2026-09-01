using System.Text.Json.Serialization;

namespace Discourse.Models;

public record PenaltyCounts
{
    [JsonPropertyName("silenced")]
    public required int Silenced { get; init; }

    [JsonPropertyName("suspended")]
    public required int Suspended { get; init; }
}
