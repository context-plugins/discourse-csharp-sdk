using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Owner
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }

    [JsonPropertyName("title")]
    public required string? Title { get; init; }

    [JsonPropertyName("last_posted_at")]
    public required string LastPostedAt { get; init; }

    [JsonPropertyName("last_seen_at")]
    public required string LastSeenAt { get; init; }

    [JsonPropertyName("added_at")]
    public required string AddedAt { get; init; }

    [JsonPropertyName("timezone")]
    public required string Timezone { get; init; }
}
