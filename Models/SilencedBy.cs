using System.Text.Json.Serialization;

namespace Discourse.Models;

public record SilencedBy
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }
}
