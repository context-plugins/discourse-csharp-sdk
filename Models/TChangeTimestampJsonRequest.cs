using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record TChangeTimestampJsonRequest
{
    [JsonPropertyName("timestamp")]
    public required string Timestamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
