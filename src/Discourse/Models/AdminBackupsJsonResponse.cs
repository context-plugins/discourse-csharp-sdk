using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record AdminBackupsJsonResponse
{
    [JsonPropertyName("filename")]
    public required string Filename { get; init; }

    [JsonPropertyName("size")]
    public required int Size { get; init; }

    [JsonPropertyName("last_modified")]
    public required string LastModified { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
