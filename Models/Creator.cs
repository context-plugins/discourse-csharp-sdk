using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Creator
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("avatar_template")]
    public required string AvatarTemplate { get; init; }
}
