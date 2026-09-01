using System.Text.Json.Serialization;

namespace Discourse.Models;

public record DirectoryItem
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("likes_received")]
    public required int LikesReceived { get; init; }

    [JsonPropertyName("likes_given")]
    public required int LikesGiven { get; init; }

    [JsonPropertyName("topics_entered")]
    public required int TopicsEntered { get; init; }

    [JsonPropertyName("topic_count")]
    public required int TopicCount { get; init; }

    [JsonPropertyName("post_count")]
    public required int PostCount { get; init; }

    [JsonPropertyName("posts_read")]
    public required int PostsRead { get; init; }

    [JsonPropertyName("days_visited")]
    public required int DaysVisited { get; init; }

    [JsonPropertyName("user")]
    public required User11 User { get; init; }
}
