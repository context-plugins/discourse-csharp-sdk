using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UploadsCompleteExternalUploadJsonRequest
{
    /// <summary>
    /// The unique identifier returned in the original /generate-presigned-put
    /// request.
    /// </summary>
    [JsonPropertyName("unique_identifier")]
    public required string UniqueIdentifier { get; init; }

    /// <summary>
    /// Optionally set this to true if the upload is for a
    /// private message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("for_private_message")]
    public string? ForPrivateMessage { get; init; }

    /// <summary>
    /// Optionally set this to true if the upload is for a
    /// site setting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("for_site_setting")]
    public string? ForSiteSetting { get; init; }

    /// <summary>
    /// Optionally set this to true if the upload was pasted
    /// into the upload area. This will convert PNG files to JPEG.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pasted")]
    public string? Pasted { get; init; }
}
