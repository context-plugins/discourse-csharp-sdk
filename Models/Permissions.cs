using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Permissions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("everyone")]
    public int? Everyone { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("staff")]
    public int? Staff { get; init; }
}
