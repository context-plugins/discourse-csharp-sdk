using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminUsersSilenceJsonResponse
{
    [JsonPropertyName("silence")]
    public required Silence Silence { get; init; }
}
