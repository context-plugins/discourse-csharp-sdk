using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TagGroupsJsonResponse3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public string? Success { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tag_group")]
    public TagGroup2? TagGroup { get; init; }
}
