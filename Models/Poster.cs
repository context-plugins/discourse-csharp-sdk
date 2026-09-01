using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Poster
{
    [JsonPropertyName("extras")]
    public required string Extras { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("user_id")]
    public required int UserId { get; init; }

    [JsonPropertyName("primary_group_id")]
    public required int? PrimaryGroupId { get; init; }
}
