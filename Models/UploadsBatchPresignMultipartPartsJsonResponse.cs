using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UploadsBatchPresignMultipartPartsJsonResponse
{
    /// <summary>
    /// The presigned URLs for each part number, which has
    /// the part numbers as keys.
    /// </summary>
    [JsonPropertyName("presigned_urls")]
    public required object PresignedUrls { get; init; }
}
