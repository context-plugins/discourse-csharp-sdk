using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Participant1
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }

    [JsonPropertyName("post_count")]
    public required int PostCount { get; init; }

    [JsonPropertyName("primary_group_name")]
    public required string? PrimaryGroupName { get; init; }

    [JsonPropertyName("flair_name")]
    public required string? FlairName { get; init; }

    [JsonPropertyName("flair_url")]
    public required string? FlairUrl { get; init; }

    [JsonPropertyName("flair_color")]
    public required string? FlairColor { get; init; }

    [JsonPropertyName("flair_bg_color")]
    public required string? FlairBgColor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flair_group_id")]
    public int? FlairGroupId { get; init; }

    [JsonPropertyName("admin")]
    public required bool Admin { get; init; }

    [JsonPropertyName("moderator")]
    public required bool Moderator { get; init; }

    [JsonPropertyName("trust_level")]
    public required int TrustLevel { get; init; }
}
