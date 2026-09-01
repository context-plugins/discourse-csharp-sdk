using System.Collections.Generic;
using System.Text.Json.Serialization;
using Discourse.Models.Enums;

namespace Discourse.Models;

public record UpcomingChangesStat
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("humanized_name")]
    public required string HumanizedName { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    [JsonPropertyName("specific_groups")]
    public required IReadOnlyList<string> SpecificGroups { get; init; }

    [JsonPropertyName("reason")]
    public required Reason Reason { get; init; }
}
