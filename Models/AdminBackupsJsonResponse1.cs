using System.Text.Json.Serialization;

namespace Discourse.Models;

public record AdminBackupsJsonResponse1
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }
}
