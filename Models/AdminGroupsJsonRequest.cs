using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminGroupsJsonRequest
{
    [JsonPropertyName("group")]
    public required Group Group { get; init; }
}
