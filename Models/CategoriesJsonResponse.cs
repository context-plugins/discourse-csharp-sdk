using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record CategoriesJsonResponse
{
    [JsonPropertyName("category")]
    public required Category Category { get; init; }
}
