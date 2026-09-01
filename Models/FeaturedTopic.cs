using System.Text.Json.Serialization;

namespace Discourse.Models;

public record FeaturedTopic
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
}
