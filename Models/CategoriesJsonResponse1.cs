using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record CategoriesJsonResponse1
{
    [JsonPropertyName("category_list")]
    public required CategoryList CategoryList { get; init; }
}
