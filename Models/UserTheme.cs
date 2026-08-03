using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UserTheme
{
    [JsonPropertyName("theme_id")]
    public required int ThemeId { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("default")]
    public required bool Default { get; init; }

    [JsonPropertyName("color_scheme_id")]
    public required int? ColorSchemeId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dark_color_scheme_id")]
    public int? DarkColorSchemeId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("only_theme_color_schemes")]
    public bool? OnlyThemeColorSchemes { get; init; }
}
