using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Category1
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("color")]
    public required string Color { get; init; }

    [JsonPropertyName("text_color")]
    public required string TextColor { get; init; }

    [JsonPropertyName("style_type")]
    public required string StyleType { get; init; }

    [JsonPropertyName("emoji")]
    public required string? Emoji { get; init; }

    [JsonPropertyName("icon")]
    public required string? Icon { get; init; }

    [JsonPropertyName("slug")]
    public required string Slug { get; init; }

    [JsonPropertyName("topic_count")]
    public required int TopicCount { get; init; }

    [JsonPropertyName("post_count")]
    public required int PostCount { get; init; }

    [JsonPropertyName("position")]
    public required int Position { get; init; }

    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    [JsonPropertyName("description_text")]
    public required string? DescriptionText { get; init; }

    [JsonPropertyName("description_excerpt")]
    public required string? DescriptionExcerpt { get; init; }

    [JsonPropertyName("topic_url")]
    public required string? TopicUrl { get; init; }

    [JsonPropertyName("read_restricted")]
    public required bool ReadRestricted { get; init; }

    [JsonPropertyName("permission")]
    public required int Permission { get; init; }

    [JsonPropertyName("notification_level")]
    public required int NotificationLevel { get; init; }

    [JsonPropertyName("can_edit")]
    public required bool CanEdit { get; init; }

    [JsonPropertyName("topic_template")]
    public required string? TopicTemplate { get; init; }

    [JsonPropertyName("topic_title_placeholder")]
    public required string? TopicTitlePlaceholder { get; init; }

    [JsonPropertyName("has_children")]
    public required bool HasChildren { get; init; }

    [JsonPropertyName("subcategory_count")]
    public required int? SubcategoryCount { get; init; }

    [JsonPropertyName("sort_order")]
    public required string? SortOrder { get; init; }

    [JsonPropertyName("sort_ascending")]
    public required string? SortAscending { get; init; }

    [JsonPropertyName("show_subcategory_list")]
    public required bool ShowSubcategoryList { get; init; }

    [JsonPropertyName("num_featured_topics")]
    public required int NumFeaturedTopics { get; init; }

    [JsonPropertyName("default_view")]
    public required string? DefaultView { get; init; }

    [JsonPropertyName("subcategory_list_style")]
    public required string SubcategoryListStyle { get; init; }

    [JsonPropertyName("default_top_period")]
    public required string DefaultTopPeriod { get; init; }

    [JsonPropertyName("default_list_filter")]
    public required string DefaultListFilter { get; init; }

    [JsonPropertyName("minimum_required_tags")]
    public required int MinimumRequiredTags { get; init; }

    [JsonPropertyName("navigate_to_first_post_after_read")]
    public required bool NavigateToFirstPostAfterRead { get; init; }

    [JsonPropertyName("topics_day")]
    public required int TopicsDay { get; init; }

    [JsonPropertyName("topics_week")]
    public required int TopicsWeek { get; init; }

    [JsonPropertyName("topics_month")]
    public required int TopicsMonth { get; init; }

    [JsonPropertyName("topics_year")]
    public required int TopicsYear { get; init; }

    [JsonPropertyName("topics_all_time")]
    public required int TopicsAllTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_uncategorized")]
    public bool? IsUncategorized { get; init; }

    [JsonPropertyName("subcategory_ids")]
    public required IReadOnlyList<object> SubcategoryIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subcategory_list")]
    public IReadOnlyList<object>? SubcategoryList { get; init; }

    [JsonPropertyName("uploaded_logo")]
    public required string? UploadedLogo { get; init; }

    [JsonPropertyName("uploaded_logo_dark")]
    public required string? UploadedLogoDark { get; init; }

    [JsonPropertyName("uploaded_background")]
    public required string? UploadedBackground { get; init; }

    [JsonPropertyName("uploaded_background_dark")]
    public required string? UploadedBackgroundDark { get; init; }
}
