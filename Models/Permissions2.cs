using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Models;

namespace DiscourseApiDocumentation.Models;

public record Permissions2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("everyone")]
    public int? Everyone { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
