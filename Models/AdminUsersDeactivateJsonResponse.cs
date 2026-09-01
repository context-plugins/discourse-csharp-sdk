using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminUsersDeactivateJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
