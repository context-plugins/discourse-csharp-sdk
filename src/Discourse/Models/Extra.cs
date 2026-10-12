using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record Extra
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categories")]
    public string? Categories { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
