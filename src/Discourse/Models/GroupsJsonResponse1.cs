using System.Text.Json.Serialization;

namespace Discourse.Models;

public record GroupsJsonResponse1
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
