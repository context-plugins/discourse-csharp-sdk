using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UploadsCreateMultipartJsonResponse
{
    /// <summary>
    /// The path of the temporary file on the external storage
    /// service.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// The identifier of the multipart upload in the external
    /// storage provider. This is the multipart upload_id in AWS S3.
    /// </summary>
    [JsonPropertyName("external_upload_identifier")]
    public required string ExternalUploadIdentifier { get; init; }

    /// <summary>
    /// A unique string that identifies the external upload.
    /// This must be stored and then sent in the /complete-multipart
    /// and /batch-presign-multipart-parts endpoints.
    /// </summary>
    [JsonPropertyName("unique_identifier")]
    public required string UniqueIdentifier { get; init; }
}
