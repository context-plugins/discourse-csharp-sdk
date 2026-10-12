using System.Text.Json.Serialization;

namespace Discourse.Models;

public record CategoriesJsonResponse1
{
    [JsonPropertyName("category_list")]
    public required CategoryList CategoryList { get; init; }
}
