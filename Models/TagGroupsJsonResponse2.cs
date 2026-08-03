using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TagGroupsJsonResponse2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tag_group")]
    public TagGroup2? TagGroup { get; init; }
}
