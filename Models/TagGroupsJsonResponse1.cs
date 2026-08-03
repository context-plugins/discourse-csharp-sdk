using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TagGroupsJsonResponse1
{
    [JsonPropertyName("tag_group")]
    public required TagGroup1 TagGroup { get; init; }
}
