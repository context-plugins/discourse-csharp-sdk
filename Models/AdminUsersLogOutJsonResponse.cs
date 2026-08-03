using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersLogOutJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
