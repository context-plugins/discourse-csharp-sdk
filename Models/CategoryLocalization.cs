using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Models;

namespace DiscourseApiDocumentation.Models;

public record CategoryLocalization
{
    /// <summary>
    /// The unique identifier for an existing localization.
    /// Must be included otherwise the record will be deleted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    /// <summary>
    /// The locale for the localization, e.g., 'en',
    /// 'zh_CN'. Locale should be in the list of SiteSetting.content_localization_supported_locales.
    /// </summary>
    [JsonPropertyName("locale")]
    public required string Locale { get; init; }

    /// <summary>
    /// The name of the category in the specified locale.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The description excerpt of the category in the
    /// specified locale.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
