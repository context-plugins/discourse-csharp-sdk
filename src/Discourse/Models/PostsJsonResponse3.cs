using System.Text.Json.Serialization;

namespace Discourse.Models;

public record PostsJsonResponse3
{
    [JsonPropertyName("post")]
    public required Post2 Post { get; init; }
}
