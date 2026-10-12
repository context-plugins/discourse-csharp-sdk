using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record PostsJsonResponse1
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("raw")]
    public string? Raw { get; init; }

    [JsonPropertyName("cooked")]
    public required string Cooked { get; init; }

    [JsonPropertyName("post_number")]
    public required int PostNumber { get; init; }

    [JsonPropertyName("post_type")]
    public required int PostType { get; init; }

    [JsonPropertyName("posts_count")]
    public required int PostsCount { get; init; }

    [JsonPropertyName("updated_at")]
    public required string UpdatedAt { get; init; }

    [JsonPropertyName("reply_count")]
    public required int ReplyCount { get; init; }

    [JsonPropertyName("reply_to_post_number")]
    public required string? ReplyToPostNumber { get; init; }

    [JsonPropertyName("quote_count")]
    public required int QuoteCount { get; init; }

    [JsonPropertyName("incoming_link_count")]
    public required int IncomingLinkCount { get; init; }

    [JsonPropertyName("reads")]
    public required int Reads { get; init; }

    [JsonPropertyName("readers_count")]
    public required int ReadersCount { get; init; }

    [JsonPropertyName("score")]
    public required double Score { get; init; }

    [JsonPropertyName("yours")]
    public required bool Yours { get; init; }

    [JsonPropertyName("topic_id")]
    public required int TopicId { get; init; }

    [JsonPropertyName("topic_slug")]
    public required string TopicSlug { get; init; }

    [JsonPropertyName("display_username")]
    public required string? DisplayUsername { get; init; }

    [JsonPropertyName("primary_group_name")]
    public required string? PrimaryGroupName { get; init; }

    [JsonPropertyName("flair_name")]
    public required string? FlairName { get; init; }

    [JsonPropertyName("flair_url")]
    public required string? FlairUrl { get; init; }

    [JsonPropertyName("flair_bg_color")]
    public required string? FlairBgColor { get; init; }

    [JsonPropertyName("flair_color")]
    public required string? FlairColor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flair_group_id")]
    public int? FlairGroupId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("badges_granted")]
    public IReadOnlyList<object>? BadgesGranted { get; init; }

    [JsonPropertyName("version")]
    public required int Version { get; init; }

    [JsonPropertyName("can_edit")]
    public required bool CanEdit { get; init; }

    [JsonPropertyName("can_delete")]
    public required bool CanDelete { get; init; }

    [JsonPropertyName("can_recover")]
    public required bool CanRecover { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_see_hidden_post")]
    public bool? CanSeeHiddenPost { get; init; }

    [JsonPropertyName("can_wiki")]
    public required bool CanWiki { get; init; }

    [JsonPropertyName("user_title")]
    public required string? UserTitle { get; init; }

    [JsonPropertyName("bookmarked")]
    public required bool Bookmarked { get; init; }

    [JsonPropertyName("actions_summary")]
    public required IReadOnlyList<ActionsSummary> ActionsSummary { get; init; }

    [JsonPropertyName("moderator")]
    public required bool Moderator { get; init; }

    [JsonPropertyName("admin")]
    public required bool Admin { get; init; }

    [JsonPropertyName("staff")]
    public required bool Staff { get; init; }

    [JsonPropertyName("user_id")]
    public required int UserId { get; init; }

    [JsonPropertyName("draft_sequence")]
    public required int DraftSequence { get; init; }

    [JsonPropertyName("hidden")]
    public required bool Hidden { get; init; }

    [JsonPropertyName("trust_level")]
    public required int TrustLevel { get; init; }

    [JsonPropertyName("deleted_at")]
    public required string? DeletedAt { get; init; }

    [JsonPropertyName("user_deleted")]
    public required bool UserDeleted { get; init; }

    [JsonPropertyName("edit_reason")]
    public required string? EditReason { get; init; }

    [JsonPropertyName("can_view_edit_history")]
    public required bool CanViewEditHistory { get; init; }

    [JsonPropertyName("wiki")]
    public required bool Wiki { get; init; }

    [JsonPropertyName("reviewable_id")]
    public required int? ReviewableId { get; init; }

    [JsonPropertyName("reviewable_score_count")]
    public required int ReviewableScoreCount { get; init; }

    [JsonPropertyName("reviewable_score_pending_count")]
    public required int ReviewableScorePendingCount { get; init; }

    [JsonPropertyName("post_url")]
    public required string PostUrl { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("post_localizations")]
    public IReadOnlyList<object>? PostLocalizations { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mentioned_users")]
    public IReadOnlyList<object>? MentionedUsers { get; init; }
}
