using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminGroupsJsonResponse1
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
