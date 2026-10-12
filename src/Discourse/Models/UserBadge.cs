using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UserBadge
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("granted_at")]
    public required string GrantedAt { get; init; }

    [JsonPropertyName("grouping_position")]
    public required int GroupingPosition { get; init; }

    [JsonPropertyName("is_favorite")]
    public required string? IsFavorite { get; init; }

    [JsonPropertyName("can_favorite")]
    public required bool CanFavorite { get; init; }

    [JsonPropertyName("badge_id")]
    public required int BadgeId { get; init; }

    [JsonPropertyName("granted_by_id")]
    public required int GrantedById { get; init; }
}
