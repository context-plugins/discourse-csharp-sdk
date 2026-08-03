using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Group10
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("automatic")]
    public required bool Automatic { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("display_name")]
    public required string DisplayName { get; init; }

    [JsonPropertyName("user_count")]
    public required int UserCount { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flair_group_id")]
    public int? FlairGroupId { get; init; }

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

    [JsonPropertyName("members_visibility_level")]
    public required int MembersVisibilityLevel { get; init; }

    [JsonPropertyName("can_see_members")]
    public required bool CanSeeMembers { get; init; }

    [JsonPropertyName("can_admin_group")]
    public required bool CanAdminGroup { get; init; }

    [JsonPropertyName("publish_read_state")]
    public required bool PublishReadState { get; init; }
}
