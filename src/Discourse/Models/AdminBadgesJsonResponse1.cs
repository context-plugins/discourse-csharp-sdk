using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminBadgesJsonResponse1
{
    [JsonPropertyName("badge_types")]
    public required IReadOnlyList<BadgeType> BadgeTypes { get; init; }

    [JsonPropertyName("badge")]
    public required Badge1 Badge { get; init; }
}
