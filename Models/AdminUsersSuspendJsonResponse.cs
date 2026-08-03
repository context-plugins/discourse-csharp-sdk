using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersSuspendJsonResponse
{
    [JsonPropertyName("suspension")]
    public required Suspension Suspension { get; init; }
}
