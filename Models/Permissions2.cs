using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Permissions2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("everyone")]
    public int? Everyone { get; init; }
}
