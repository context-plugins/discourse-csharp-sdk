using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Group1
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("automatic")]
    public required bool Automatic { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_count")]
    public int? UserCount { get; init; }

    [JsonPropertyName("mentionable_level")]
    public required int MentionableLevel { get; init; }

    [JsonPropertyName("messageable_level")]
    public required int MessageableLevel { get; init; }

    [JsonPropertyName("visibility_level")]
    public required int VisibilityLevel { get; init; }

    [JsonPropertyName("primary_group")]
    public required bool PrimaryGroup { get; init; }

    [JsonPropertyName("title")]
    public required string? Title { get; init; }

    [JsonPropertyName("grant_trust_level")]
    public required string? GrantTrustLevel { get; init; }

    [JsonPropertyName("incoming_email")]
    public required string? IncomingEmail { get; init; }

    [JsonPropertyName("has_messages")]
    public required bool HasMessages { get; init; }

    [JsonPropertyName("flair_url")]
    public required string? FlairUrl { get; init; }

    [JsonPropertyName("flair_bg_color")]
    public required string? FlairBgColor { get; init; }

    [JsonPropertyName("flair_color")]
    public required string? FlairColor { get; init; }

    [JsonPropertyName("bio_raw")]
    public required string? BioRaw { get; init; }

    [JsonPropertyName("bio_cooked")]
    public required string? BioCooked { get; init; }

    [JsonPropertyName("bio_excerpt")]
    public required string? BioExcerpt { get; init; }

    [JsonPropertyName("public_admission")]
    public required bool PublicAdmission { get; init; }

    [JsonPropertyName("public_exit")]
    public required bool PublicExit { get; init; }

    [JsonPropertyName("allow_membership_requests")]
    public required bool AllowMembershipRequests { get; init; }

    [JsonPropertyName("full_name")]
    public required string? FullName { get; init; }

    [JsonPropertyName("default_notification_level")]
    public required int DefaultNotificationLevel { get; init; }

    [JsonPropertyName("membership_request_template")]
    public required string? MembershipRequestTemplate { get; init; }

    [JsonPropertyName("is_group_user")]
    public required bool IsGroupUser { get; init; }

    [JsonPropertyName("members_visibility_level")]
    public required int MembersVisibilityLevel { get; init; }

    [JsonPropertyName("can_see_members")]
    public required bool CanSeeMembers { get; init; }

    [JsonPropertyName("can_admin_group")]
    public required bool CanAdminGroup { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_edit_group")]
    public bool? CanEditGroup { get; init; }

    [JsonPropertyName("publish_read_state")]
    public required bool PublishReadState { get; init; }

    [JsonPropertyName("is_group_owner_display")]
    public required bool IsGroupOwnerDisplay { get; init; }

    [JsonPropertyName("mentionable")]
    public required bool Mentionable { get; init; }

    [JsonPropertyName("messageable")]
    public required bool Messageable { get; init; }

    [JsonPropertyName("automatic_membership_email_domains")]
    public required string? AutomaticMembershipEmailDomains { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smtp_updated_at")]
    public string? SmtpUpdatedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smtp_updated_by")]
    public object? SmtpUpdatedBy { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smtp_enabled")]
    public bool? SmtpEnabled { get; init; }

    [JsonPropertyName("smtp_server")]
    public required string? SmtpServer { get; init; }

    [JsonPropertyName("smtp_port")]
    public required string? SmtpPort { get; init; }

    [JsonPropertyName("smtp_ssl_mode")]
    public required int? SmtpSslMode { get; init; }

    [JsonPropertyName("email_username")]
    public required string? EmailUsername { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_from_alias")]
    public string? EmailFromAlias { get; init; }

    [JsonPropertyName("email_password")]
    public required string? EmailPassword { get; init; }

    [JsonPropertyName("message_count")]
    public required int MessageCount { get; init; }

    [JsonPropertyName("allow_unknown_sender_topic_replies")]
    public required bool AllowUnknownSenderTopicReplies { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("associated_group_ids")]
    public IReadOnlyList<object>? AssociatedGroupIds { get; init; }

    [JsonPropertyName("watching_category_ids")]
    public required IReadOnlyList<object> WatchingCategoryIds { get; init; }

    [JsonPropertyName("tracking_category_ids")]
    public required IReadOnlyList<object> TrackingCategoryIds { get; init; }

    [JsonPropertyName("watching_first_post_category_ids")]
    public required IReadOnlyList<object> WatchingFirstPostCategoryIds { get; init; }

    [JsonPropertyName("regular_category_ids")]
    public required IReadOnlyList<object> RegularCategoryIds { get; init; }

    [JsonPropertyName("muted_category_ids")]
    public required IReadOnlyList<object> MutedCategoryIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("watching_tags")]
    public IReadOnlyList<object>? WatchingTags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("watching_first_post_tags")]
    public IReadOnlyList<object>? WatchingFirstPostTags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tracking_tags")]
    public IReadOnlyList<object>? TrackingTags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("regular_tags")]
    public IReadOnlyList<object>? RegularTags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("muted_tags")]
    public IReadOnlyList<object>? MutedTags { get; init; }
}
