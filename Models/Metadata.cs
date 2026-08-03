using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Metadata
{
    /// <summary>
    /// The SHA1 checksum of the upload binary blob. Optionally
    /// be provided and serves as an additional security check when
    /// later processing the file in complete-external-upload endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sha1-checksum")]
    public string? Sha1Checksum { get; init; }
}
