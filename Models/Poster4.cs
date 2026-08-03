using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Poster4
{
    [JsonPropertyName("extras")]
    public required string Extras { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("user")]
    public required User User { get; init; }
}
