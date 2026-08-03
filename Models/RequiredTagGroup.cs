using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record RequiredTagGroup
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("min_count")]
    public required int MinCount { get; init; }
}
