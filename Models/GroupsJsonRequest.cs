using System.Text.Json.Serialization;

namespace Discourse.Models;

public record GroupsJsonRequest
{
    [JsonPropertyName("group")]
    public required Group Group { get; init; }
}
