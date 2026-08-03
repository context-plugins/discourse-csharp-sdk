using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TChangeTimestampJsonRequest
{
    [JsonPropertyName("timestamp")]
    public required string Timestamp { get; init; }
}
