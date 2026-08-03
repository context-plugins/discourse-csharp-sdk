using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersAnonymizeJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }
}
