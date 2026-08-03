using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UJsonRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_ids")]
    public object? ExternalIds { get; init; }
}
