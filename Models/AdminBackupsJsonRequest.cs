using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminBackupsJsonRequest
{
    [JsonPropertyName("with_uploads")]
    public required bool WithUploads { get; init; }
}
