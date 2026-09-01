using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record Permissions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("everyone")]
    public int? Everyone { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("staff")]
    public int? Staff { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
