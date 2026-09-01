using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

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
