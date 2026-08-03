using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record PostsLockedJsonResponse
{
    /// <summary>
    /// Whether the post is locked
    /// </summary>
    [JsonPropertyName("locked")]
    public required bool Locked { get; init; }
}
