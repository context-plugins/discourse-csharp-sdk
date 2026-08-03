using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminBackupsJsonResponse1
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
