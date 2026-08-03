using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersJsonResponse
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("associated_accounts")]
    public IReadOnlyList<object>? AssociatedAccounts { get; init; }

    [JsonPropertyName("can_send_activation_email")]
    public required bool CanSendActivationEmail { get; init; }

    [JsonPropertyName("can_activate")]
    public required bool CanActivate { get; init; }

    [JsonPropertyName("can_deactivate")]
    public required bool CanDeactivate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_change_trust_level")]
    public bool? CanChangeTrustLevel { get; init; }

    [JsonPropertyName("ip_address")]
    public required string IpAddress { get; init; }

    [JsonPropertyName("registration_ip_address")]
    public required string? RegistrationIpAddress { get; init; }

    [JsonPropertyName("can_grant_admin")]
    public required bool CanGrantAdmin { get; init; }

    [JsonPropertyName("can_revoke_admin")]
    public required bool CanRevokeAdmin { get; init; }

    [JsonPropertyName("can_grant_moderation")]
    public required bool CanGrantModeration { get; init; }

    [JsonPropertyName("can_revoke_moderation")]
    public required bool CanRevokeModeration { get; init; }

    [JsonPropertyName("can_impersonate")]
    public required bool CanImpersonate { get; init; }

    [JsonPropertyName("like_count")]
    public required int LikeCount { get; init; }

    [JsonPropertyName("like_given_count")]
    public required int LikeGivenCount { get; init; }

    [JsonPropertyName("topic_count")]
    public required int TopicCount { get; init; }

    [JsonPropertyName("flags_given_count")]
    public required int FlagsGivenCount { get; init; }

    [JsonPropertyName("flags_received_count")]
    public required int FlagsReceivedCount { get; init; }

    [JsonPropertyName("private_topics_count")]
    public required int PrivateTopicsCount { get; init; }

    [JsonPropertyName("can_delete_all_posts")]
    public required bool CanDeleteAllPosts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_be_deleted")]
    public bool? CanBeDeleted { get; init; }

    [JsonPropertyName("can_be_anonymized")]
    public required bool CanBeAnonymized { get; init; }

    [JsonPropertyName("can_be_merged")]
    public required bool CanBeMerged { get; init; }

    [JsonPropertyName("full_suspend_reason")]
    public required string? FullSuspendReason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latest_export")]
    public object? LatestExport { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("full_silence_reason")]
    public string? FullSilenceReason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("silence_reason")]
    public string? SilenceReason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("post_edits_count")]
    public int? PostEditsCount { get; init; }

    [JsonPropertyName("primary_group_id")]
    public required int? PrimaryGroupId { get; init; }

    [JsonPropertyName("badge_count")]
    public required int BadgeCount { get; init; }

    [JsonPropertyName("warnings_received_count")]
    public required int WarningsReceivedCount { get; init; }

    [JsonPropertyName("bounce_score")]
    public required int? BounceScore { get; init; }

    [JsonPropertyName("reset_bounce_score_after")]
    public required string? ResetBounceScoreAfter { get; init; }

    [JsonPropertyName("can_view_action_logs")]
    public required bool CanViewActionLogs { get; init; }

    [JsonPropertyName("can_disable_second_factor")]
    public required bool CanDisableSecondFactor { get; init; }

    [JsonPropertyName("can_delete_sso_record")]
    public required bool CanDeleteSsoRecord { get; init; }

    [JsonPropertyName("api_key_count")]
    public required int ApiKeyCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("similar_users_count")]
    public int? SimilarUsersCount { get; init; }

    [JsonPropertyName("single_sign_on_record")]
    public required string? SingleSignOnRecord { get; init; }

    [JsonPropertyName("approved_by")]
    public required ApprovedBy? ApprovedBy { get; init; }

    [JsonPropertyName("suspended_by")]
    public required string? SuspendedBy { get; init; }

    [JsonPropertyName("silenced_by")]
    public required string? SilencedBy { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("penalty_counts")]
    public PenaltyCounts? PenaltyCounts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_penalty")]
    public string? NextPenalty { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tl3_requirements")]
    public Tl3Requirements? Tl3Requirements { get; init; }

    [JsonPropertyName("groups")]
    public required IReadOnlyList<Group10> Groups { get; init; }

    [JsonPropertyName("external_ids")]
    public required object ExternalIds { get; init; }

    [JsonPropertyName("include_ip")]
    public required bool IncludeIp { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upcoming_changes_stats")]
    public IReadOnlyList<UpcomingChangesStat>? UpcomingChangesStats { get; init; }
}
