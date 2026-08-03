using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UserBadgesJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("badges")]
    public IReadOnlyList<Badge3>? Badges { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("badge_types")]
    public IReadOnlyList<BadgeType>? BadgeTypes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("granted_bies")]
    public IReadOnlyList<GrantedBy>? GrantedBies { get; init; }

    [JsonPropertyName("user_badges")]
    public required IReadOnlyList<UserBadge> UserBadges { get; init; }
}
