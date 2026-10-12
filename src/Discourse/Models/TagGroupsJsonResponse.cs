using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record TagGroupsJsonResponse
{
    [JsonPropertyName("tag_groups")]
    public required IReadOnlyList<TagGroup> TagGroups { get; init; }
}
