using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UserAuthToken
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("client_ip")]
    public required string ClientIp { get; init; }

    [JsonPropertyName("location")]
    public required string Location { get; init; }

    [JsonPropertyName("browser")]
    public required string Browser { get; init; }

    [JsonPropertyName("device")]
    public required string Device { get; init; }

    [JsonPropertyName("os")]
    public required string Os { get; init; }

    [JsonPropertyName("icon")]
    public required string Icon { get; init; }

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonPropertyName("seen_at")]
    public required string SeenAt { get; init; }

    [JsonPropertyName("is_active")]
    public required bool IsActive { get; init; }
}
