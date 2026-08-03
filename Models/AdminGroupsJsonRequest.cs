using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminGroupsJsonRequest
{
    [JsonPropertyName("group")]
    public required Group Group { get; init; }
}
