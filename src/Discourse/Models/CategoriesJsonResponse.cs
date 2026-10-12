using System.Text.Json.Serialization;

namespace Discourse.Models;

public record CategoriesJsonResponse
{
    [JsonPropertyName("category")]
    public required Category Category { get; init; }
}
