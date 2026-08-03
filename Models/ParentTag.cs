using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record ParentTag
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("slug")]
    public required string Slug { get; init; }
}
