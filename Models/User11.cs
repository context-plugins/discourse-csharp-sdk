using System.Text.Json.Serialization;

namespace Discourse.Models;

public record User11
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
}
