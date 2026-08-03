using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record CategoriesJsonResponse2
{
    [JsonPropertyName("success")]
    public required string Success { get; init; }

    [JsonPropertyName("category")]
    public required Category2 Category { get; init; }
}
