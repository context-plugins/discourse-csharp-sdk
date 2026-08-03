using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UploadsAbortMultipartJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
