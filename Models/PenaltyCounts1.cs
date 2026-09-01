using System.Text.Json.Serialization;

namespace Discourse.Models;

public record PenaltyCounts1
{
    [JsonPropertyName("silenced")]
    public required int Silenced { get; init; }

    [JsonPropertyName("suspended")]
    public required int Suspended { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
