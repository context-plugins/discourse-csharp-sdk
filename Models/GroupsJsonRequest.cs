using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record GroupsJsonRequest
{
    [JsonPropertyName("group")]
    public required Group Group { get; init; }
}
