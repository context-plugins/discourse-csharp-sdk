using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UPreferencesAvatarPickJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
