using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record PostsLockedJsonRequest
{
    /// <summary>
    /// Whether to lock the post (true/false)
    /// </summary>
    [JsonPropertyName("locked")]
    public required string Locked { get; init; }
}
