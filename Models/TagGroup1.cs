using System.Collections.Generic;
using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Models;

namespace DiscourseApiDocumentation.Models;

public record TagGroup1
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
    public required object Permissions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
