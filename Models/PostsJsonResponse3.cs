using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record PostsJsonResponse3
{
    [JsonPropertyName("post")]
    public required Post2 Post { get; init; }
}
