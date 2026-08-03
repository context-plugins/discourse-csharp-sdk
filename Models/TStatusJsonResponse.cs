using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TStatusJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public string? Success { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topic_status_update")]
    public string? TopicStatusUpdate { get; init; }
}
