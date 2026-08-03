using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Triggers
{
    [JsonPropertyName("user_change")]
    public required int UserChange { get; init; }

    [JsonPropertyName("none")]
    public required int None { get; init; }

    [JsonPropertyName("post_revision")]
    public required int PostRevision { get; init; }

    [JsonPropertyName("trust_level_change")]
    public required int TrustLevelChange { get; init; }

    [JsonPropertyName("post_action")]
    public required int PostAction { get; init; }
}
