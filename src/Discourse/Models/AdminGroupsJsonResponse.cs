using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminGroupsJsonResponse
{
    [JsonPropertyName("basic_group")]
    public required BasicGroup BasicGroup { get; init; }
}
