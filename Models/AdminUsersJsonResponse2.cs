using System.Collections.Generic;
using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Models;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersJsonResponse2
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_emails")]
    public IReadOnlyList<object>? SecondaryEmails { get; init; }

    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    [JsonPropertyName("admin")]
    public required bool Admin { get; init; }

    [JsonPropertyName("moderator")]
    public required bool Moderator { get; init; }

    [JsonPropertyName("last_seen_at")]
    public required string? LastSeenAt { get; init; }

    [JsonPropertyName("last_emailed_at")]
    public required string? LastEmailedAt { get; init; }

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonPropertyName("last_seen_age")]
    public required double? LastSeenAge { get; init; }

    [JsonPropertyName("last_emailed_age")]
    public required double? LastEmailedAge { get; init; }

    [JsonPropertyName("created_at_age")]
    public required double? CreatedAtAge { get; init; }

    [JsonPropertyName("trust_level")]
    public required int TrustLevel { get; init; }

    [JsonPropertyName("manual_locked_trust_level")]
    public required string? ManualLockedTrustLevel { get; init; }

    [JsonPropertyName("title")]
    public required string? Title { get; init; }

    [JsonPropertyName("time_read")]
    public required int TimeRead { get; init; }

    [JsonPropertyName("staged")]
    public required bool Staged { get; init; }

    [JsonPropertyName("days_visited")]
    public required int DaysVisited { get; init; }

    [JsonPropertyName("posts_read_count")]
    public required int PostsReadCount { get; init; }

    [JsonPropertyName("topics_entered")]
    public required int TopicsEntered { get; init; }

    [JsonPropertyName("post_count")]
    public required int PostCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
