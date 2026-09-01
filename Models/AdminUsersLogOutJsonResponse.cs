using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminUsersLogOutJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
