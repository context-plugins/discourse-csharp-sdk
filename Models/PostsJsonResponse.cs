using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record PostsJsonResponse
{
    [JsonPropertyName("latest_posts")]
    public required IReadOnlyList<LatestPost> LatestPosts { get; init; }
}
