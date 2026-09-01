using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UPreferencesAvatarPickJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
