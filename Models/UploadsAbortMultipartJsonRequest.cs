using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UploadsAbortMultipartJsonRequest
{
    /// <summary>
    /// The identifier of the multipart upload in the external
    /// storage provider. This is the multipart upload_id in AWS S3.
    /// </summary>
    [JsonPropertyName("external_upload_identifier")]
    public required string ExternalUploadIdentifier { get; init; }
}
