using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TNotificationsJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public string? Success { get; init; }
}
