using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Tl3Requirements
{
    [JsonPropertyName("time_period")]
    public required int TimePeriod { get; init; }

    [JsonPropertyName("requirements_met")]
    public required bool RequirementsMet { get; init; }

    [JsonPropertyName("requirements_lost")]
    public required bool RequirementsLost { get; init; }

    [JsonPropertyName("trust_level_locked")]
    public required bool TrustLevelLocked { get; init; }

    [JsonPropertyName("on_grace_period")]
    public required bool OnGracePeriod { get; init; }

    [JsonPropertyName("days_visited")]
    public required int DaysVisited { get; init; }

    [JsonPropertyName("min_days_visited")]
    public required int MinDaysVisited { get; init; }

    [JsonPropertyName("num_topics_replied_to")]
    public required int NumTopicsRepliedTo { get; init; }

    [JsonPropertyName("min_topics_replied_to")]
    public required int MinTopicsRepliedTo { get; init; }

    [JsonPropertyName("topics_viewed")]
    public required int TopicsViewed { get; init; }

    [JsonPropertyName("min_topics_viewed")]
    public required int MinTopicsViewed { get; init; }

    [JsonPropertyName("posts_read")]
    public required int PostsRead { get; init; }

    [JsonPropertyName("min_posts_read")]
    public required int MinPostsRead { get; init; }

    [JsonPropertyName("topics_viewed_all_time")]
    public required int TopicsViewedAllTime { get; init; }

    [JsonPropertyName("min_topics_viewed_all_time")]
    public required int MinTopicsViewedAllTime { get; init; }

    [JsonPropertyName("posts_read_all_time")]
    public required int PostsReadAllTime { get; init; }

    [JsonPropertyName("min_posts_read_all_time")]
    public required int MinPostsReadAllTime { get; init; }

    [JsonPropertyName("num_flagged_posts")]
    public required int NumFlaggedPosts { get; init; }

    [JsonPropertyName("max_flagged_posts")]
    public required int MaxFlaggedPosts { get; init; }

    [JsonPropertyName("num_flagged_by_users")]
    public required int NumFlaggedByUsers { get; init; }

    [JsonPropertyName("max_flagged_by_users")]
    public required int MaxFlaggedByUsers { get; init; }

    [JsonPropertyName("num_likes_given")]
    public required int NumLikesGiven { get; init; }

    [JsonPropertyName("min_likes_given")]
    public required int MinLikesGiven { get; init; }

    [JsonPropertyName("num_likes_received")]
    public required int NumLikesReceived { get; init; }

    [JsonPropertyName("min_likes_received")]
    public required int MinLikesReceived { get; init; }

    [JsonPropertyName("num_likes_received_days")]
    public required int NumLikesReceivedDays { get; init; }

    [JsonPropertyName("min_likes_received_days")]
    public required int MinLikesReceivedDays { get; init; }

    [JsonPropertyName("num_likes_received_users")]
    public required int NumLikesReceivedUsers { get; init; }

    [JsonPropertyName("min_likes_received_users")]
    public required int MinLikesReceivedUsers { get; init; }

    [JsonPropertyName("penalty_counts")]
    public required PenaltyCounts1 PenaltyCounts { get; init; }
}
