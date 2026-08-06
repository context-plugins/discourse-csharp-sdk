using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Category4
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("color")]
    public required string Color { get; init; }

    [JsonPropertyName("text_color")]
    public required string TextColor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("style_type")]
    public string? StyleType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emoji")]
    public string? Emoji { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("slug")]
    public required string Slug { get; init; }

    [JsonPropertyName("topic_count")]
    public required int TopicCount { get; init; }

    [JsonPropertyName("post_count")]
    public required int PostCount { get; init; }

    [JsonPropertyName("position")]
    public required int Position { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description_text")]
    public string? DescriptionText { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description_excerpt")]
    public string? DescriptionExcerpt { get; init; }

    [JsonPropertyName("topic_url")]
    public required string TopicUrl { get; init; }

    [JsonPropertyName("read_restricted")]
    public required bool ReadRestricted { get; init; }

    [JsonPropertyName("permission")]
    public required int? Permission { get; init; }

    [JsonPropertyName("notification_level")]
    public required int NotificationLevel { get; init; }

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
    public required bool? SortAscending { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed_tags")]
    public IReadOnlyList<object>? AllowedTags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed_tag_groups")]
    public IReadOnlyList<object>? AllowedTagGroups { get; init; }

    [JsonPropertyName("allow_global_tags")]
    public required bool AllowGlobalTags { get; init; }

    [JsonPropertyName("required_tag_groups")]
    public required IReadOnlyList<RequiredTagGroup> RequiredTagGroups { get; init; }

    [JsonPropertyName("read_only_banner")]
    public required string? ReadOnlyBanner { get; init; }

    [JsonPropertyName("uploaded_logo")]
    public required string? UploadedLogo { get; init; }

    [JsonPropertyName("uploaded_logo_dark")]
    public required string? UploadedLogoDark { get; init; }

    [JsonPropertyName("uploaded_background")]
    public required string? UploadedBackground { get; init; }

    [JsonPropertyName("uploaded_background_dark")]
    public required string? UploadedBackgroundDark { get; init; }

    [JsonPropertyName("can_edit")]
    public required bool CanEdit { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public object? CustomFields { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parent_category_id")]
    public int? ParentCategoryId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("form_template_ids")]
    public IReadOnlyList<object>? FormTemplateIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_types")]
    public object? CategoryTypes { get; init; }
}
