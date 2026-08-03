using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record PenaltyCounts
{
    [JsonPropertyName("silenced")]
    public required int Silenced { get; init; }

    [JsonPropertyName("suspended")]
    public required int Suspended { get; init; }
}
