using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersDeactivateJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
