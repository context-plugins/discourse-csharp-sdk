using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Category2
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

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
    public required int? Permission { get; init; }

    [JsonPropertyName("notification_level")]
    public required int NotificationLevel { get; init; }

    [JsonPropertyName("can_edit")]
    public required bool CanEdit { get; init; }

    [JsonPropertyName("topic_template")]
    public required string? TopicTemplate { get; init; }

    [JsonPropertyName("topic_title_placeholder")]
    public required string? TopicTitlePlaceholder { get; init; }

    [JsonPropertyName("form_template_ids")]
    public required IReadOnlyList<object> FormTemplateIds { get; init; }

    [JsonPropertyName("has_children")]
    public required bool? HasChildren { get; init; }

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

    [JsonPropertyName("custom_fields")]
    public required object CustomFields { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed_tags")]
    public IReadOnlyList<object>? AllowedTags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed_tag_groups")]
    public IReadOnlyList<object>? AllowedTagGroups { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_global_tags")]
    public bool? AllowGlobalTags { get; init; }

    [JsonPropertyName("required_tag_groups")]
    public required IReadOnlyList<RequiredTagGroup> RequiredTagGroups { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_setting")]
    public CategorySetting? CategorySetting { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_localizations")]
    public IReadOnlyList<object>? CategoryLocalizations { get; init; }

    [JsonPropertyName("read_only_banner")]
    public required string? ReadOnlyBanner { get; init; }

    [JsonPropertyName("available_groups")]
    public required IReadOnlyList<object> AvailableGroups { get; init; }

    [JsonPropertyName("auto_close_hours")]
    public required string? AutoCloseHours { get; init; }

    [JsonPropertyName("auto_close_based_on_last_post")]
    public required bool AutoCloseBasedOnLastPost { get; init; }

    [JsonPropertyName("allow_unlimited_owner_edits_on_first_post")]
    public required bool AllowUnlimitedOwnerEditsOnFirstPost { get; init; }

    [JsonPropertyName("default_slow_mode_seconds")]
    public required string? DefaultSlowModeSeconds { get; init; }

    [JsonPropertyName("group_permissions")]
    public required IReadOnlyList<GroupPermission> GroupPermissions { get; init; }

    [JsonPropertyName("email_in")]
    public required string? EmailIn { get; init; }

    [JsonPropertyName("email_in_allow_strangers")]
    public required bool EmailInAllowStrangers { get; init; }

    [JsonPropertyName("mailinglist_mirror")]
    public required bool MailinglistMirror { get; init; }

    [JsonPropertyName("all_topics_wiki")]
    public required bool AllTopicsWiki { get; init; }

    [JsonPropertyName("can_delete")]
    public required bool CanDelete { get; init; }

    [JsonPropertyName("allow_badges")]
    public required bool AllowBadges { get; init; }

    [JsonPropertyName("topic_featured_link_allowed")]
    public required bool TopicFeaturedLinkAllowed { get; init; }

    [JsonPropertyName("search_priority")]
    public required int SearchPriority { get; init; }

    [JsonPropertyName("topic_posting_review_group_ids")]
    public required IReadOnlyList<int> TopicPostingReviewGroupIds { get; init; }

    [JsonPropertyName("reply_posting_review_group_ids")]
    public required IReadOnlyList<int> ReplyPostingReviewGroupIds { get; init; }

    [JsonPropertyName("uploaded_logo")]
    public required string? UploadedLogo { get; init; }

    [JsonPropertyName("uploaded_logo_dark")]
    public required string? UploadedLogoDark { get; init; }

    [JsonPropertyName("uploaded_background")]
    public required string? UploadedBackground { get; init; }

    [JsonPropertyName("uploaded_background_dark")]
    public required string? UploadedBackgroundDark { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_types")]
    public object? CategoryTypes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_type_settings")]
    public object? CategoryTypeSettings { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_category_types")]
    public IReadOnlyList<AvailableCategoryType>? AvailableCategoryTypes { get; init; }
}
