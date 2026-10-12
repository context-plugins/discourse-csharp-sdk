using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminBadgesJsonRequest1
{
    /// <summary>
    /// The name for the new badge.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The ID for the badge type. 1 for Gold, 2 for Silver,
    /// 3 for Bronze.
    /// </summary>
    [JsonPropertyName("badge_type_id")]
    public required int BadgeTypeId { get; init; }
}
