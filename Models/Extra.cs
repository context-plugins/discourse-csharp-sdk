using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Extra
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categories")]
    public string? Categories { get; init; }
}
