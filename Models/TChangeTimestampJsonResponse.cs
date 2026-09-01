using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record TChangeTimestampJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public string? Success { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
