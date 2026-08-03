using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record SiteBasicInfoJsonResponse
{
    [JsonPropertyName("logo_url")]
    public required string LogoUrl { get; init; }

    [JsonPropertyName("logo_small_url")]
    public required string LogoSmallUrl { get; init; }

    [JsonPropertyName("apple_touch_icon_url")]
    public required string AppleTouchIconUrl { get; init; }

    [JsonPropertyName("favicon_url")]
    public required string FaviconUrl { get; init; }

    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("header_primary_color")]
    public required string HeaderPrimaryColor { get; init; }

    [JsonPropertyName("header_background_color")]
    public required string HeaderBackgroundColor { get; init; }

    [JsonPropertyName("login_required")]
    public required bool LoginRequired { get; init; }

    [JsonPropertyName("locale")]
    public required string Locale { get; init; }

    [JsonPropertyName("include_in_discourse_discover")]
    public required bool IncludeInDiscourseDiscover { get; init; }

    [JsonPropertyName("mobile_logo_url")]
    public required string MobileLogoUrl { get; init; }
}
