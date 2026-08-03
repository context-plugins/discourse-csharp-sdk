using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Topic1
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("fancy_title")]
    public required string FancyTitle { get; init; }

    [JsonPropertyName("slug")]
    public required string Slug { get; init; }

    [JsonPropertyName("posts_count")]
    public required int PostsCount { get; init; }

    [JsonPropertyName("reply_count")]
    public required int ReplyCount { get; init; }

    [JsonPropertyName("highest_post_number")]
    public required int HighestPostNumber { get; init; }

    [JsonPropertyName("image_url")]
    public required string? ImageUrl { get; init; }

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonPropertyName("last_posted_at")]
    public required string LastPostedAt { get; init; }

    [JsonPropertyName("bumped")]
    public required bool Bumped { get; init; }

    [JsonPropertyName("bumped_at")]
    public required string BumpedAt { get; init; }

    [JsonPropertyName("archetype")]
    public required string Archetype { get; init; }

    [JsonPropertyName("unseen")]
    public required bool Unseen { get; init; }

    [JsonPropertyName("pinned")]
    public required bool Pinned { get; init; }

    [JsonPropertyName("unpinned")]
    public required string? Unpinned { get; init; }

    [JsonPropertyName("excerpt")]
    public required string Excerpt { get; init; }

    [JsonPropertyName("visible")]
    public required bool Visible { get; init; }

    [JsonPropertyName("closed")]
    public required bool Closed { get; init; }

    [JsonPropertyName("archived")]
    public required bool Archived { get; init; }

    [JsonPropertyName("bookmarked")]
    public required string? Bookmarked { get; init; }

    [JsonPropertyName("liked")]
    public required string? Liked { get; init; }

    [JsonPropertyName("views")]
    public required int Views { get; init; }

    [JsonPropertyName("like_count")]
    public required int LikeCount { get; init; }

    [JsonPropertyName("has_summary")]
    public required bool HasSummary { get; init; }

    [JsonPropertyName("last_poster_username")]
    public required string LastPosterUsername { get; init; }

    [JsonPropertyName("category_id")]
    public required int CategoryId { get; init; }

    [JsonPropertyName("pinned_globally")]
    public required bool PinnedGlobally { get; init; }

    [JsonPropertyName("featured_link")]
    public required string? FeaturedLink { get; init; }

    [JsonPropertyName("posters")]
    public required IReadOnlyList<Poster> Posters { get; init; }
}
