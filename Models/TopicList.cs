using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TopicList
{
    [JsonPropertyName("can_create_topic")]
    public required bool CanCreateTopic { get; init; }

    [JsonPropertyName("per_page")]
    public required int PerPage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_tags")]
    public IReadOnlyList<TopTag>? TopTags { get; init; }

    [JsonPropertyName("topics")]
    public required IReadOnlyList<Topic1> Topics { get; init; }
}
