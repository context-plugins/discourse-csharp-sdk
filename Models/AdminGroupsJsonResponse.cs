using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminGroupsJsonResponse
{
    [JsonPropertyName("basic_group")]
    public required BasicGroup BasicGroup { get; init; }
}
