using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TagGroup
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("tags")]
    public required IReadOnlyList<Tag> Tags { get; init; }

    [JsonPropertyName("parent_tag")]
    public required IReadOnlyList<ParentTag> ParentTag { get; init; }

    [JsonPropertyName("one_per_topic")]
    public required bool OnePerTopic { get; init; }

    [JsonPropertyName("permissions")]
    public required IReadOnlyDictionary<string, int> Permissions { get; init; }
}
