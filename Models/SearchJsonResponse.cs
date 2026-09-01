using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record SearchJsonResponse
{
    [JsonPropertyName("posts")]
    public required IReadOnlyList<object> Posts { get; init; }

    [JsonPropertyName("users")]
    public required IReadOnlyList<object> Users { get; init; }

    [JsonPropertyName("categories")]
    public required IReadOnlyList<object> Categories { get; init; }

    [JsonPropertyName("tags")]
    public required IReadOnlyList<Tag> Tags { get; init; }

    [JsonPropertyName("groups")]
    public required IReadOnlyList<object> Groups { get; init; }

    [JsonPropertyName("grouped_search_result")]
    public required GroupedSearchResult GroupedSearchResult { get; init; }
}
