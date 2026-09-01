using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record GroupsJsonResponse2
{
    [JsonPropertyName("groups")]
    public required IReadOnlyList<Group4> Groups { get; init; }

    [JsonPropertyName("extras")]
    public required Extras2 Extras { get; init; }

    [JsonPropertyName("total_rows_groups")]
    public required int TotalRowsGroups { get; init; }

    [JsonPropertyName("load_more_groups")]
    public required string LoadMoreGroups { get; init; }
}
