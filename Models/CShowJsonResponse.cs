using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record CShowJsonResponse
{
    [JsonPropertyName("category")]
    public required Category Category { get; init; }
}
