using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UploadsGeneratePresignedPutJsonResponse
{
    /// <summary>
    /// The path of the temporary file on the external storage
    /// service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// A presigned PUT URL which must be used to upload
    /// the file binary blob to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// A map of headers that must be sent with the PUT request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signed_headers")]
    public object? SignedHeaders { get; init; }

    /// <summary>
    /// A unique string that identifies the external upload.
    /// This must be stored and then sent in the /complete-external-upload
    /// endpoint to complete the direct upload.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unique_identifier")]
    public string? UniqueIdentifier { get; init; }
}
