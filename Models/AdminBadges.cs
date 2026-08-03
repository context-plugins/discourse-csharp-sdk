using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminBadges
{
    [JsonPropertyName("protected_system_fields")]
    public required IReadOnlyList<object> ProtectedSystemFields { get; init; }

    [JsonPropertyName("triggers")]
    public required Triggers Triggers { get; init; }

    [JsonPropertyName("badge_ids")]
    public required IReadOnlyList<object> BadgeIds { get; init; }

    [JsonPropertyName("badge_grouping_ids")]
    public required IReadOnlyList<object> BadgeGroupingIds { get; init; }

    [JsonPropertyName("badge_type_ids")]
    public required IReadOnlyList<object> BadgeTypeIds { get; init; }
}
