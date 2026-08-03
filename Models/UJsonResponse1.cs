using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UJsonResponse1
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }

    [JsonPropertyName("user")]
    public required object User { get; init; }
}
