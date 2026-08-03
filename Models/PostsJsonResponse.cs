using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record PostsJsonResponse
{
    [JsonPropertyName("latest_posts")]
    public required IReadOnlyList<LatestPost> LatestPosts { get; init; }
}
