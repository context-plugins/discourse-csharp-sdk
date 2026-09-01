using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record UserOption
{
    [JsonPropertyName("user_id")]
    public required int UserId { get; init; }

    [JsonPropertyName("mailing_list_mode")]
    public required bool MailingListMode { get; init; }

    [JsonPropertyName("mailing_list_mode_frequency")]
    public required int MailingListModeFrequency { get; init; }

    [JsonPropertyName("email_digests")]
    public required bool EmailDigests { get; init; }

    [JsonPropertyName("email_level")]
    public required int EmailLevel { get; init; }

    [JsonPropertyName("email_messages_level")]
    public required int EmailMessagesLevel { get; init; }

    [JsonPropertyName("external_links_in_new_tab")]
    public required bool ExternalLinksInNewTab { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bookmark_auto_delete_preference")]
    public int? BookmarkAutoDeletePreference { get; init; }

    [JsonPropertyName("color_scheme_id")]
    public required string? ColorSchemeId { get; init; }

    [JsonPropertyName("dark_scheme_id")]
    public required string? DarkSchemeId { get; init; }

    [JsonPropertyName("dynamic_favicon")]
    public required bool DynamicFavicon { get; init; }

    [JsonPropertyName("enable_quoting")]
    public required bool EnableQuoting { get; init; }

    [JsonPropertyName("enable_smart_lists")]
    public required bool EnableSmartLists { get; init; }

    [JsonPropertyName("enable_markdown_monospace_font")]
    public required bool EnableMarkdownMonospaceFont { get; init; }

    [JsonPropertyName("enable_defer")]
    public required bool EnableDefer { get; init; }

    [JsonPropertyName("digest_after_minutes")]
    public required int DigestAfterMinutes { get; init; }

    [JsonPropertyName("automatically_unpin_topics")]
    public required bool AutomaticallyUnpinTopics { get; init; }

    [JsonPropertyName("auto_track_topics_after_msecs")]
    public required int AutoTrackTopicsAfterMsecs { get; init; }

    [JsonPropertyName("notification_level_when_replying")]
    public required int NotificationLevelWhenReplying { get; init; }

    [JsonPropertyName("new_topic_duration_minutes")]
    public required int NewTopicDurationMinutes { get; init; }

    [JsonPropertyName("email_previous_replies")]
    public required int EmailPreviousReplies { get; init; }

    [JsonPropertyName("email_in_reply_to")]
    public required bool EmailInReplyTo { get; init; }

    [JsonPropertyName("like_notification_frequency")]
    public required int LikeNotificationFrequency { get; init; }

    [JsonPropertyName("notify_on_linked_posts")]
    public required bool NotifyOnLinkedPosts { get; init; }

    [JsonPropertyName("push_notification_level")]
    public required string PushNotificationLevel { get; init; }

    [JsonPropertyName("enable_upcoming_change_available_notifications")]
    public required bool EnableUpcomingChangeAvailableNotifications { get; init; }

    [JsonPropertyName("include_tl0_in_digests")]
    public required bool IncludeTl0InDigests { get; init; }

    [JsonPropertyName("theme_ids")]
    public required IReadOnlyList<object> ThemeIds { get; init; }

    [JsonPropertyName("theme_key_seq")]
    public required int ThemeKeySeq { get; init; }

    [JsonPropertyName("allow_private_messages")]
    public required bool AllowPrivateMessages { get; init; }

    [JsonPropertyName("enable_allowed_pm_users")]
    public required bool EnableAllowedPmUsers { get; init; }

    [JsonPropertyName("homepage_id")]
    public required string? HomepageId { get; init; }

    [JsonPropertyName("hide_profile_and_presence")]
    public required bool HideProfileAndPresence { get; init; }

    [JsonPropertyName("hide_profile")]
    public required bool HideProfile { get; init; }

    [JsonPropertyName("hide_presence")]
    public required bool HidePresence { get; init; }

    [JsonPropertyName("text_size")]
    public required string TextSize { get; init; }

    [JsonPropertyName("text_size_seq")]
    public required int TextSizeSeq { get; init; }

    [JsonPropertyName("title_count_mode")]
    public required string TitleCountMode { get; init; }

    [JsonPropertyName("timezone")]
    public required string? Timezone { get; init; }

    [JsonPropertyName("skip_new_user_tips")]
    public required bool SkipNewUserTips { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default_calendar")]
    public string? DefaultCalendar { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oldest_search_log_date")]
    public string? OldestSearchLogDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sidebar_link_to_filtered_list")]
    public bool? SidebarLinkToFilteredList { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sidebar_show_count_of_new_items")]
    public bool? SidebarShowCountOfNewItems { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("watched_precedence_over_muted")]
    public bool? WatchedPrecedenceOverMuted { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seen_popups")]
    public string? SeenPopups { get; init; }

    [JsonPropertyName("topics_unread_when_closed")]
    public required bool TopicsUnreadWhenClosed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("composition_mode")]
    public int? CompositionMode { get; init; }

    [JsonPropertyName("interface_color_mode")]
    public required int InterfaceColorMode { get; init; }

    [JsonPropertyName("show_original_content")]
    public required bool ShowOriginalContent { get; init; }
}
