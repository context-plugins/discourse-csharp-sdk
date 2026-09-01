using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UsersPasswordResetJsonRequest
{
    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("password")]
    public required string Password { get; init; }
}
