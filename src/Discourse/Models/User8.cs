using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record User8
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }

    [JsonPropertyName("last_posted_at")]
    public required string? LastPostedAt { get; init; }

    [JsonPropertyName("last_seen_at")]
    public required string? LastSeenAt { get; init; }

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonPropertyName("ignored")]
    public required bool Ignored { get; init; }

    [JsonPropertyName("muted")]
    public required bool Muted { get; init; }

    [JsonPropertyName("can_ignore_user")]
    public required bool CanIgnoreUser { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_ignore_users")]
    public bool? CanIgnoreUsers { get; init; }

    [JsonPropertyName("can_mute_user")]
    public required bool CanMuteUser { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_mute_users")]
    public bool? CanMuteUsers { get; init; }

    [JsonPropertyName("can_send_private_messages")]
    public required bool CanSendPrivateMessages { get; init; }

    [JsonPropertyName("can_send_private_message_to_user")]
    public required bool CanSendPrivateMessageToUser { get; init; }

    [JsonPropertyName("trust_level")]
    public required int TrustLevel { get; init; }

    [JsonPropertyName("moderator")]
    public required bool Moderator { get; init; }

    [JsonPropertyName("admin")]
    public required bool Admin { get; init; }

    [JsonPropertyName("title")]
    public required string? Title { get; init; }

    [JsonPropertyName("badge_count")]
    public required int BadgeCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("second_factor_backup_enabled")]
    public bool? SecondFactorBackupEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_fields")]
    public IReadOnlyDictionary<string, string>? UserFields { get; init; }

    [JsonPropertyName("custom_fields")]
    public required CustomFields CustomFields { get; init; }

    [JsonPropertyName("time_read")]
    public required int TimeRead { get; init; }

    [JsonPropertyName("recent_time_read")]
    public required int RecentTimeRead { get; init; }

    [JsonPropertyName("primary_group_id")]
    public required int? PrimaryGroupId { get; init; }

    [JsonPropertyName("primary_group_name")]
    public required string? PrimaryGroupName { get; init; }

    [JsonPropertyName("flair_group_id")]
    public required int? FlairGroupId { get; init; }

    [JsonPropertyName("flair_name")]
    public required string? FlairName { get; init; }

    [JsonPropertyName("flair_url")]
    public required string? FlairUrl { get; init; }

    [JsonPropertyName("flair_bg_color")]
    public required string? FlairBgColor { get; init; }

    [JsonPropertyName("flair_color")]
    public required string? FlairColor { get; init; }

    [JsonPropertyName("featured_topic")]
    public required FeaturedTopic FeaturedTopic { get; init; }

    [JsonPropertyName("staged")]
    public required bool Staged { get; init; }

    [JsonPropertyName("can_edit")]
    public required bool CanEdit { get; init; }

    [JsonPropertyName("can_edit_username")]
    public required bool CanEditUsername { get; init; }

    [JsonPropertyName("can_edit_email")]
    public required bool CanEditEmail { get; init; }

    [JsonPropertyName("can_edit_name")]
    public required bool CanEditName { get; init; }

    [JsonPropertyName("uploaded_avatar_id")]
    public required int? UploadedAvatarId { get; init; }

    [JsonPropertyName("has_title_badges")]
    public required bool HasTitleBadges { get; init; }

    [JsonPropertyName("pending_count")]
    public required int PendingCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pending_posts_count")]
    public int? PendingPostsCount { get; init; }

    [JsonPropertyName("profile_view_count")]
    public required int ProfileViewCount { get; init; }

    [JsonPropertyName("second_factor_enabled")]
    public required bool SecondFactorEnabled { get; init; }

    [JsonPropertyName("can_upload_profile_header")]
    public required bool CanUploadProfileHeader { get; init; }

    [JsonPropertyName("can_upload_user_card_background")]
    public required bool CanUploadUserCardBackground { get; init; }

    [JsonPropertyName("post_count")]
    public required int PostCount { get; init; }

    [JsonPropertyName("topic_count")]
    public required int TopicCount { get; init; }

    [JsonPropertyName("can_be_deleted")]
    public required bool CanBeDeleted { get; init; }

    [JsonPropertyName("can_delete_all_posts")]
    public required bool CanDeleteAllPosts { get; init; }

    [JsonPropertyName("locale")]
    public required string? Locale { get; init; }

    [JsonPropertyName("muted_category_ids")]
    public required IReadOnlyList<object> MutedCategoryIds { get; init; }

    [JsonPropertyName("regular_category_ids")]
    public required IReadOnlyList<object> RegularCategoryIds { get; init; }

    [JsonPropertyName("watched_tags")]
    public required IReadOnlyList<object> WatchedTags { get; init; }

    [JsonPropertyName("watching_first_post_tags")]
    public required IReadOnlyList<object> WatchingFirstPostTags { get; init; }

    [JsonPropertyName("tracked_tags")]
    public required IReadOnlyList<object> TrackedTags { get; init; }

    [JsonPropertyName("muted_tags")]
    public required IReadOnlyList<object> MutedTags { get; init; }

    [JsonPropertyName("tracked_category_ids")]
    public required IReadOnlyList<object> TrackedCategoryIds { get; init; }

    [JsonPropertyName("watched_category_ids")]
    public required IReadOnlyList<object> WatchedCategoryIds { get; init; }

    [JsonPropertyName("watched_first_post_category_ids")]
    public required IReadOnlyList<object> WatchedFirstPostCategoryIds { get; init; }

    [JsonPropertyName("system_avatar_upload_id")]
    public required string? SystemAvatarUploadId { get; init; }

    [JsonPropertyName("system_avatar_template")]
    public required string SystemAvatarTemplate { get; init; }

    [JsonPropertyName("muted_usernames")]
    public required IReadOnlyList<object> MutedUsernames { get; init; }

    [JsonPropertyName("ignored_usernames")]
    public required IReadOnlyList<object> IgnoredUsernames { get; init; }

    [JsonPropertyName("allowed_pm_usernames")]
    public required IReadOnlyList<object> AllowedPmUsernames { get; init; }

    [JsonPropertyName("mailing_list_posts_per_day")]
    public required int MailingListPostsPerDay { get; init; }

    [JsonPropertyName("can_change_bio")]
    public required bool CanChangeBio { get; init; }

    [JsonPropertyName("can_change_location")]
    public required bool CanChangeLocation { get; init; }

    [JsonPropertyName("can_change_website")]
    public required bool CanChangeWebsite { get; init; }

    [JsonPropertyName("can_change_tracking_preferences")]
    public required bool CanChangeTrackingPreferences { get; init; }

    [JsonPropertyName("user_api_keys")]
    public required string? UserApiKeys { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_passkeys")]
    public IReadOnlyList<object>? UserPasskeys { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sidebar_tags")]
    public IReadOnlyList<object>? SidebarTags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sidebar_category_ids")]
    public IReadOnlyList<object>? SidebarCategoryIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_sidebar_tags")]
    public bool? DisplaySidebarTags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_pick_theme_with_custom_homepage")]
    public bool? CanPickThemeWithCustomHomepage { get; init; }

    [JsonPropertyName("user_auth_tokens")]
    public required IReadOnlyList<UserAuthToken> UserAuthTokens { get; init; }

    [JsonPropertyName("user_notification_schedule")]
    public required UserNotificationSchedule UserNotificationSchedule { get; init; }

    [JsonPropertyName("use_logo_small_as_avatar")]
    public required bool UseLogoSmallAsAvatar { get; init; }

    [JsonPropertyName("featured_user_badge_ids")]
    public required IReadOnlyList<object> FeaturedUserBadgeIds { get; init; }

    [JsonPropertyName("invited_by")]
    public required string? InvitedBy { get; init; }

    [JsonPropertyName("groups")]
    public required IReadOnlyList<Group7> Groups { get; init; }

    [JsonPropertyName("group_users")]
    public required IReadOnlyList<GroupUser> GroupUsers { get; init; }

    [JsonPropertyName("user_option")]
    public required UserOption UserOption { get; init; }
}
