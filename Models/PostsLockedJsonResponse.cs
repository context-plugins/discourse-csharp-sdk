using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Models;

namespace DiscourseApiDocumentation.Models;

public record PostsLockedJsonResponse
{
    /// <summary>
    /// Whether the post is locked
    /// </summary>
    [JsonPropertyName("locked")]
    public required bool Locked { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
