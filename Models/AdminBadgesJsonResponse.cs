using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminBadgesJsonResponse
{
    [JsonPropertyName("badges")]
    public required IReadOnlyList<Badge> Badges { get; init; }

    [JsonPropertyName("badge_types")]
    public required IReadOnlyList<BadgeType> BadgeTypes { get; init; }

    [JsonPropertyName("badge_groupings")]
    public required IReadOnlyList<BadgeGrouping> BadgeGroupings { get; init; }

    [JsonPropertyName("admin_badges")]
    public required AdminBadges AdminBadges { get; init; }
}
