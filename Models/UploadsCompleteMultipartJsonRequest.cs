using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UploadsCompleteMultipartJsonRequest
{
    /// <summary>
    /// The unique identifier returned in the original /create-multipart
    /// request.
    /// </summary>
    [JsonPropertyName("unique_identifier")]
    public required string UniqueIdentifier { get; init; }

    /// <summary>
    /// All of the part numbers and their corresponding ETags
    /// that have been uploaded must be provided.
    /// </summary>
    [JsonPropertyName("parts")]
    public required IReadOnlyList<object> Parts { get; init; }
}
