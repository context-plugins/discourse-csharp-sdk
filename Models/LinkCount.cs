using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record LinkCount
{
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonPropertyName("internal")]
    public required bool Internal { get; init; }

    [JsonPropertyName("reflection")]
    public required bool Reflection { get; init; }

    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("clicks")]
    public required int Clicks { get; init; }
}
