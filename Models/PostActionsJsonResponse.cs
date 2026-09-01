using System.Collections.Generic;
using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Models;

namespace DiscourseApiDocumentation.Models;

public record PostActionsJsonResponse
{
    /// <summary>
    /// The ID of the post
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    /// <summary>
    /// The name of the post author
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The username of the post author
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; init; }

    /// <summary>
    /// Template for the author's avatar URL
    /// </summary>
    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }

    /// <summary>
    /// When the post was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// The HTML content of the post
    /// </summary>
    [JsonPropertyName("cooked")]
    public required string Cooked { get; init; }

    /// <summary>
    /// The post number within the topic
    /// </summary>
    [JsonPropertyName("post_number")]
    public required int PostNumber { get; init; }

    /// <summary>
    /// The type of post
    /// </summary>
    [JsonPropertyName("post_type")]
    public required int PostType { get; init; }

    /// <summary>
    /// Total posts count for the user
    /// </summary>
    [JsonPropertyName("posts_count")]
    public required int PostsCount { get; init; }

    /// <summary>
    /// When the post was last updated
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required string UpdatedAt { get; init; }

    /// <summary>
    /// Number of replies to this post
    /// </summary>
    [JsonPropertyName("reply_count")]
    public required int ReplyCount { get; init; }

    /// <summary>
    /// Post number this post is replying to
    /// </summary>
    [JsonPropertyName("reply_to_post_number")]
    public required string? ReplyToPostNumber { get; init; }

    /// <summary>
    /// Number of times this post has been quoted
    /// </summary>
    [JsonPropertyName("quote_count")]
    public required int QuoteCount { get; init; }

    /// <summary>
    /// Number of incoming links to this post
    /// </summary>
    [JsonPropertyName("incoming_link_count")]
    public required int IncomingLinkCount { get; init; }

    /// <summary>
    /// Number of reads
    /// </summary>
    [JsonPropertyName("reads")]
    public required int Reads { get; init; }

    /// <summary>
    /// Number of readers
    /// </summary>
    [JsonPropertyName("readers_count")]
    public required int ReadersCount { get; init; }

    /// <summary>
    /// Post score
    /// </summary>
    [JsonPropertyName("score")]
    public required double Score { get; init; }

    /// <summary>
    /// Whether this post belongs to the current user
    /// </summary>
    [JsonPropertyName("yours")]
    public required bool Yours { get; init; }

    /// <summary>
    /// ID of the topic this post belongs to
    /// </summary>
    [JsonPropertyName("topic_id")]
    public required int TopicId { get; init; }

    /// <summary>
    /// Slug of the topic this post belongs to
    /// </summary>
    [JsonPropertyName("topic_slug")]
    public required string TopicSlug { get; init; }

    /// <summary>
    /// Display username of the post author
    /// </summary>
    [JsonPropertyName("display_username")]
    public required string DisplayUsername { get; init; }

    /// <summary>
    /// Primary group name of the author
    /// </summary>
    [JsonPropertyName("primary_group_name")]
    public required string? PrimaryGroupName { get; init; }

    /// <summary>
    /// Flair name of the author
    /// </summary>
    [JsonPropertyName("flair_name")]
    public required string? FlairName { get; init; }

    /// <summary>
    /// Flair URL of the author
    /// </summary>
    [JsonPropertyName("flair_url")]
    public required string? FlairUrl { get; init; }

    /// <summary>
    /// Flair background color of the author
    /// </summary>
    [JsonPropertyName("flair_bg_color")]
    public required string? FlairBgColor { get; init; }

    /// <summary>
    /// Flair color of the author
    /// </summary>
    [JsonPropertyName("flair_color")]
    public required string? FlairColor { get; init; }

    /// <summary>
    /// Flair group ID of the author
    /// </summary>
    [JsonPropertyName("flair_group_id")]
    public required int? FlairGroupId { get; init; }

    /// <summary>
    /// Badges granted to the user
    /// </summary>
    [JsonPropertyName("badges_granted")]
    public required IReadOnlyList<object> BadgesGranted { get; init; }

    /// <summary>
    /// Version number of the post
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    /// <summary>
    /// Whether the current user can edit this post
    /// </summary>
    [JsonPropertyName("can_edit")]
    public required bool CanEdit { get; init; }

    /// <summary>
    /// Whether the current user can delete this post
    /// </summary>
    [JsonPropertyName("can_delete")]
    public required bool CanDelete { get; init; }

    /// <summary>
    /// Whether the current user can recover this post
    /// </summary>
    [JsonPropertyName("can_recover")]
    public required bool CanRecover { get; init; }

    /// <summary>
    /// Whether the current user can see hidden posts
    /// </summary>
    [JsonPropertyName("can_see_hidden_post")]
    public required bool CanSeeHiddenPost { get; init; }

    /// <summary>
    /// Whether the current user can wiki this post
    /// </summary>
    [JsonPropertyName("can_wiki")]
    public required bool CanWiki { get; init; }

    /// <summary>
    /// Title of the post author
    /// </summary>
    [JsonPropertyName("user_title")]
    public required string? UserTitle { get; init; }

    /// <summary>
    /// Whether the post is bookmarked by the current user
    /// </summary>
    [JsonPropertyName("bookmarked")]
    public required bool Bookmarked { get; init; }

    /// <summary>
    /// Summary of actions performed on this post
    /// </summary>
    [JsonPropertyName("actions_summary")]
    public required IReadOnlyList<ActionsSummary5> ActionsSummary { get; init; }

    /// <summary>
    /// Whether the post author is a moderator
    /// </summary>
    [JsonPropertyName("moderator")]
    public required bool Moderator { get; init; }

    /// <summary>
    /// Whether the post author is an admin
    /// </summary>
    [JsonPropertyName("admin")]
    public required bool Admin { get; init; }

    /// <summary>
    /// Whether the post author is staff
    /// </summary>
    [JsonPropertyName("staff")]
    public required bool Staff { get; init; }

    /// <summary>
    /// ID of the post author
    /// </summary>
    [JsonPropertyName("user_id")]
    public required int UserId { get; init; }

    /// <summary>
    /// Whether the post is hidden
    /// </summary>
    [JsonPropertyName("hidden")]
    public required bool Hidden { get; init; }

    /// <summary>
    /// Trust level of the post author
    /// </summary>
    [JsonPropertyName("trust_level")]
    public required int TrustLevel { get; init; }

    /// <summary>
    /// When the post was deleted
    /// </summary>
    [JsonPropertyName("deleted_at")]
    public required string? DeletedAt { get; init; }

    /// <summary>
    /// Whether the post was deleted by the user
    /// </summary>
    [JsonPropertyName("user_deleted")]
    public required bool UserDeleted { get; init; }

    /// <summary>
    /// Reason for the last edit
    /// </summary>
    [JsonPropertyName("edit_reason")]
    public required string? EditReason { get; init; }

    /// <summary>
    /// Whether the current user can view edit history
    /// </summary>
    [JsonPropertyName("can_view_edit_history")]
    public required bool CanViewEditHistory { get; init; }

    /// <summary>
    /// Whether this is a wiki post
    /// </summary>
    [JsonPropertyName("wiki")]
    public required bool Wiki { get; init; }

    /// <summary>
    /// ID of the reviewable if this post is under review
    /// </summary>
    [JsonPropertyName("reviewable_id")]
    public required int? ReviewableId { get; init; }

    /// <summary>
    /// Number of reviewable scores
    /// </summary>
    [JsonPropertyName("reviewable_score_count")]
    public required int ReviewableScoreCount { get; init; }

    /// <summary>
    /// Number of pending reviewable scores
    /// </summary>
    [JsonPropertyName("reviewable_score_pending_count")]
    public required int ReviewableScorePendingCount { get; init; }

    /// <summary>
    /// URL of the post
    /// </summary>
    [JsonPropertyName("post_url")]
    public required string PostUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
