using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UserColorScheme
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("is_dark")]
    public required bool IsDark { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("theme_id")]
    public int? ThemeId { get; init; }

    [JsonPropertyName("colors")]
    public required IReadOnlyList<object> Colors { get; init; }
}
