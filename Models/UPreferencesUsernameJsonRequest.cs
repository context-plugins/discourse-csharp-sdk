using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UPreferencesUsernameJsonRequest
{
    [JsonPropertyName("new_username")]
    public required string NewUsername { get; init; }
}
