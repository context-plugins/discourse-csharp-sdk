using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Topic5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_id")]
    public int? CategoryId { get; init; }
}
