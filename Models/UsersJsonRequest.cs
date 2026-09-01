using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UsersJsonRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("password")]
    public required string Password { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    /// <summary>
    /// This param requires an admin api key in the request
    /// header or it will be ignored
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("approved")]
    public bool? Approved { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_fields")]
    public IReadOnlyDictionary<string, bool>? UserFields { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_ids")]
    public object? ExternalIds { get; init; }
}
