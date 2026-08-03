using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Models.Enums;

namespace DiscourseApiDocumentation.Models;

public record UploadsCreateMultipartJsonRequest
{
    [JsonPropertyName("upload_type")]
    public required UploadType1 UploadType { get; init; }

    [JsonPropertyName("file_name")]
    public required string FileName { get; init; }

    /// <summary>
    /// File size should be represented in bytes.
    /// </summary>
    [JsonPropertyName("file_size")]
    public required int FileSize { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public Metadata? Metadata { get; init; }
}
