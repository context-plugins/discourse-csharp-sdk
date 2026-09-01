using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminUsersSuspendJsonResponse
{
    [JsonPropertyName("suspension")]
    public required Suspension Suspension { get; init; }
}
