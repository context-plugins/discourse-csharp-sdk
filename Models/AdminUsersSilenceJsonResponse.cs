using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersSilenceJsonResponse
{
    [JsonPropertyName("silence")]
    public required Silence Silence { get; init; }
}
