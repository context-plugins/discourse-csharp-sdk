using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UploadsAbortMultipartJsonResponse
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
