using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminUsersActivateJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
