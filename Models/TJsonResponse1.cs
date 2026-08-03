using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TJsonResponse1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("basic_topic")]
    public BasicTopic? BasicTopic { get; init; }
}
