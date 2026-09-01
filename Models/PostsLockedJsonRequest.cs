using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Models;

namespace DiscourseApiDocumentation.Models;

public record PostsLockedJsonRequest
{
    /// <summary>
    /// Whether to lock the post (true/false)
    /// </summary>
    [JsonPropertyName("locked")]
    public required string Locked { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
