using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record Permissions2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("everyone")]
    public int? Everyone { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
