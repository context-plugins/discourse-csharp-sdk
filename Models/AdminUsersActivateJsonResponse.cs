using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersActivateJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
