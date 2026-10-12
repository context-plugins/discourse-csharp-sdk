using System.Text.Json.Serialization;
using Discourse.Core.Models;
using Discourse.Models.Enums;

namespace Discourse.Models;

public record TStatusJsonRequest
{
    [JsonPropertyName("status")]
    public required Status1 Status { get; init; }

    [JsonPropertyName("enabled")]
    public required Enabled Enabled { get; init; }

    /// <summary>
    /// Only required for <c>pinned</c> and <c>pinned_globally</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("until")]
    public string? Until { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
