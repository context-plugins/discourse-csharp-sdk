using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record SiteJsonResponse
{
    [JsonPropertyName("default_archetype")]
    public required string DefaultArchetype { get; init; }

    [JsonPropertyName("notification_types")]
    public required NotificationTypes NotificationTypes { get; init; }

    [JsonPropertyName("post_types")]
    public required PostTypes PostTypes { get; init; }

    [JsonPropertyName("trust_levels")]
    public required TrustLevels TrustLevels { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_tips")]
    public UserTips? UserTips { get; init; }

    [JsonPropertyName("groups")]
    public required IReadOnlyList<Group5> Groups { get; init; }

    [JsonPropertyName("filters")]
    public required IReadOnlyList<object> Filters { get; init; }

    [JsonPropertyName("homepage_choices")]
    public required IReadOnlyList<object> HomepageChoices { get; init; }

    [JsonPropertyName("periods")]
    public required IReadOnlyList<object> Periods { get; init; }

    [JsonPropertyName("top_menu_items")]
    public required IReadOnlyList<object> TopMenuItems { get; init; }

    [JsonPropertyName("anonymous_top_menu_items")]
    public required IReadOnlyList<object> AnonymousTopMenuItems { get; init; }

    [JsonPropertyName("uncategorized_category_id")]
    public required int UncategorizedCategoryId { get; init; }

    [JsonPropertyName("user_field_max_length")]
    public required int UserFieldMaxLength { get; init; }

    [JsonPropertyName("post_action_types")]
    public required IReadOnlyList<PostActionType> PostActionTypes { get; init; }

    [JsonPropertyName("topic_flag_types")]
    public required IReadOnlyList<TopicFlagType> TopicFlagTypes { get; init; }

    [JsonPropertyName("can_create_tag")]
    public required bool CanCreateTag { get; init; }

    [JsonPropertyName("can_tag_topics")]
    public required bool CanTagTopics { get; init; }

    [JsonPropertyName("can_tag_pms")]
    public required bool CanTagPms { get; init; }

    [JsonPropertyName("tags_filter_regexp")]
    public required string TagsFilterRegexp { get; init; }

    [JsonPropertyName("top_tags")]
    public required IReadOnlyList<TopTag> TopTags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wizard_required")]
    public bool? WizardRequired { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_associate_groups")]
    public bool? CanAssociateGroups { get; init; }

    [JsonPropertyName("email_configured")]
    public required bool EmailConfigured { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upcoming_changes_with_css")]
    public IReadOnlyList<string>? UpcomingChangesWithCss { get; init; }

    [JsonPropertyName("topic_featured_link_allowed_category_ids")]
    public required IReadOnlyList<object> TopicFeaturedLinkAllowedCategoryIds { get; init; }

    [JsonPropertyName("user_themes")]
    public required IReadOnlyList<UserTheme> UserThemes { get; init; }

    [JsonPropertyName("user_color_schemes")]
    public required IReadOnlyList<UserColorScheme> UserColorSchemes { get; init; }

    [JsonPropertyName("default_light_color_scheme")]
    public required object? DefaultLightColorScheme { get; init; }

    [JsonPropertyName("default_dark_color_scheme")]
    public required object? DefaultDarkColorScheme { get; init; }

    [JsonPropertyName("censored_regexp")]
    public required IReadOnlyList<object> CensoredRegexp { get; init; }

    [JsonPropertyName("custom_emoji_translation")]
    public required object CustomEmojiTranslation { get; init; }

    [JsonPropertyName("watched_words_replace")]
    public required object? WatchedWordsReplace { get; init; }

    [JsonPropertyName("watched_words_link")]
    public required object? WatchedWordsLink { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("markdown_additional_options")]
    public object? MarkdownAdditionalOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hashtag_configurations")]
    public object? HashtagConfigurations { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hashtag_icons")]
    public object? HashtagIcons { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayed_about_plugin_stat_groups")]
    public IReadOnlyList<object>? DisplayedAboutPluginStatGroups { get; init; }

    [JsonPropertyName("categories")]
    public required IReadOnlyList<Category4> Categories { get; init; }

    [JsonPropertyName("archetypes")]
    public required IReadOnlyList<Archetype> Archetypes { get; init; }

    [JsonPropertyName("user_fields")]
    public required IReadOnlyList<object> UserFields { get; init; }

    [JsonPropertyName("auth_providers")]
    public required IReadOnlyList<object> AuthProviders { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whispers_allowed_groups_names")]
    public IReadOnlyList<object>? WhispersAllowedGroupsNames { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("denied_emojis")]
    public IReadOnlyList<object>? DeniedEmojis { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valid_flag_applies_to_types")]
    public IReadOnlyList<object>? ValidFlagAppliesToTypes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("navigation_menu_site_top_tags")]
    public IReadOnlyList<object>? NavigationMenuSiteTopTags { get; init; }

    [JsonPropertyName("full_name_required_for_signup")]
    public required bool FullNameRequiredForSignup { get; init; }

    [JsonPropertyName("full_name_visible_in_signup")]
    public required bool FullNameVisibleInSignup { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("admin_config_login_routes")]
    public IReadOnlyList<object>? AdminConfigLoginRoutes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_control")]
    public AccessControl? AccessControl { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("permanent_upcoming_change_names")]
    public IReadOnlyList<string>? PermanentUpcomingChangeNames { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_types")]
    public IReadOnlyList<CategoryType>? CategoryTypes { get; init; }
}
