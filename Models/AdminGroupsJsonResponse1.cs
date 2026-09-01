using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminGroupsJsonResponse1
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
