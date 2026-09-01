using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Post
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("post_number")]
    public required int PostNumber { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonPropertyName("category_slug")]
    public required string CategorySlug { get; init; }

    [JsonPropertyName("topic")]
    public required Topic Topic { get; init; }
}
