using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TChangeTimestampJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public string? Success { get; init; }
}
