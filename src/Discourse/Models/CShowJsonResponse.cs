using System.Text.Json.Serialization;

namespace Discourse.Models;

public record CShowJsonResponse
{
    [JsonPropertyName("category")]
    public required Category Category { get; init; }
}
