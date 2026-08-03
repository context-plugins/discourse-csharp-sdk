using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Group5
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("full_name")]
    public string? FullName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("flair_url")]
    public required string? FlairUrl { get; init; }

    [JsonPropertyName("flair_bg_color")]
    public required string? FlairBgColor { get; init; }

    [JsonPropertyName("flair_color")]
    public required string? FlairColor { get; init; }

    [JsonPropertyName("automatic")]
    public required bool Automatic { get; init; }
}
