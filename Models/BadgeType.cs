using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record BadgeType
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("sort_order")]
    public required int SortOrder { get; init; }
}
