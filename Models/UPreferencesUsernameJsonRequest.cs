using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UPreferencesUsernameJsonRequest
{
    [JsonPropertyName("new_username")]
    public required string NewUsername { get; init; }
}
