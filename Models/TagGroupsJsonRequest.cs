using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TagGroupsJsonRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
