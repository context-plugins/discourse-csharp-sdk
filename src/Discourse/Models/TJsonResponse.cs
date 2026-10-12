using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record TJsonResponse
{
    [JsonPropertyName("post_stream")]
    public required PostStream1 PostStream { get; init; }

    [JsonPropertyName("timeline_lookup")]
    public required IReadOnlyList<object> TimelineLookup { get; init; }

    [JsonPropertyName("suggested_topics")]
    public required IReadOnlyList<SuggestedTopic> SuggestedTopics { get; init; }

    [JsonPropertyName("tags")]
    public required IReadOnlyList<Tag> Tags { get; init; }

    [JsonPropertyName("tags_descriptions")]
    public required object TagsDescriptions { get; init; }

    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("fancy_title")]
    public required string FancyTitle { get; init; }

    [JsonPropertyName("posts_count")]
    public required int PostsCount { get; init; }

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonPropertyName("views")]
    public required int Views { get; init; }

    [JsonPropertyName("reply_count")]
    public required int ReplyCount { get; init; }

    [JsonPropertyName("like_count")]
    public required int LikeCount { get; init; }

    [JsonPropertyName("last_posted_at")]
    public required string? LastPostedAt { get; init; }

    [JsonPropertyName("visible")]
    public required bool Visible { get; init; }

    [JsonPropertyName("closed")]
    public required bool Closed { get; init; }

    [JsonPropertyName("archived")]
    public required bool Archived { get; init; }

    [JsonPropertyName("has_summary")]
    public required bool HasSummary { get; init; }

    [JsonPropertyName("archetype")]
    public required string Archetype { get; init; }

    [JsonPropertyName("slug")]
    public required string Slug { get; init; }

    [JsonPropertyName("category_id")]
    public required int CategoryId { get; init; }

    [JsonPropertyName("word_count")]
    public required int? WordCount { get; init; }

    [JsonPropertyName("deleted_at")]
    public required string? DeletedAt { get; init; }

    [JsonPropertyName("user_id")]
    public required int UserId { get; init; }

    [JsonPropertyName("featured_link")]
    public required string? FeaturedLink { get; init; }

    [JsonPropertyName("pinned_globally")]
    public required bool PinnedGlobally { get; init; }

    [JsonPropertyName("pinned_at")]
    public required string? PinnedAt { get; init; }

    [JsonPropertyName("pinned_until")]
    public required string? PinnedUntil { get; init; }

    [JsonPropertyName("image_url")]
    public required string? ImageUrl { get; init; }

    [JsonPropertyName("slow_mode_seconds")]
    public required int SlowModeSeconds { get; init; }

    [JsonPropertyName("draft")]
    public required string? Draft { get; init; }

    [JsonPropertyName("draft_key")]
    public required string DraftKey { get; init; }

    [JsonPropertyName("draft_sequence")]
    public required int DraftSequence { get; init; }

    [JsonPropertyName("unpinned")]
    public required string? Unpinned { get; init; }

    [JsonPropertyName("pinned")]
    public required bool Pinned { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_post_number")]
    public int? CurrentPostNumber { get; init; }

    [JsonPropertyName("highest_post_number")]
    public required int? HighestPostNumber { get; init; }

    [JsonPropertyName("deleted_by")]
    public required string? DeletedBy { get; init; }

    [JsonPropertyName("has_deleted")]
    public required bool HasDeleted { get; init; }

    [JsonPropertyName("actions_summary")]
    public required IReadOnlyList<ActionsSummary8> ActionsSummary { get; init; }

    [JsonPropertyName("chunk_size")]
    public required int ChunkSize { get; init; }

    [JsonPropertyName("bookmarked")]
    public required bool Bookmarked { get; init; }

    [JsonPropertyName("bookmarks")]
    public required IReadOnlyList<object> Bookmarks { get; init; }

    [JsonPropertyName("topic_timer")]
    public required string? TopicTimer { get; init; }

    [JsonPropertyName("message_bus_last_id")]
    public required int MessageBusLastId { get; init; }

    [JsonPropertyName("participant_count")]
    public required int ParticipantCount { get; init; }

    [JsonPropertyName("show_read_indicator")]
    public required bool ShowReadIndicator { get; init; }

    [JsonPropertyName("thumbnails")]
    public required string? Thumbnails { get; init; }

    [JsonPropertyName("slow_mode_enabled_until")]
    public required string? SlowModeEnabledUntil { get; init; }

    [JsonPropertyName("details")]
    public required Details Details { get; init; }
}
