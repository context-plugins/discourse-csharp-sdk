using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UploadsBatchPresignMultipartPartsJsonRequest
{
    /// <summary>
    /// The part numbers to generate the presigned URLs for,
    /// must be between 1 and 10000.
    /// </summary>
    [JsonPropertyName("part_numbers")]
    public required IReadOnlyList<object> PartNumbers { get; init; }

    /// <summary>
    /// The unique identifier returned in the original /create-multipart
    /// request.
    /// </summary>
    [JsonPropertyName("unique_identifier")]
    public required string UniqueIdentifier { get; init; }
}
