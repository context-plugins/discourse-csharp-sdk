using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TJsonRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topic")]
    public Topic5? Topic { get; init; }
}
