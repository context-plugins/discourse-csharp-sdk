using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record Details
{
    [JsonPropertyName("can_edit")]
    public required bool CanEdit { get; init; }

    [JsonPropertyName("notification_level")]
    public required int NotificationLevel { get; init; }

    [JsonPropertyName("can_move_posts")]
    public required bool CanMovePosts { get; init; }

    [JsonPropertyName("can_delete")]
    public required bool CanDelete { get; init; }

    [JsonPropertyName("can_remove_allowed_users")]
    public required bool CanRemoveAllowedUsers { get; init; }

    [JsonPropertyName("can_create_post")]
    public required bool CanCreatePost { get; init; }

    [JsonPropertyName("can_reply_as_new_topic")]
    public required bool CanReplyAsNewTopic { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_invite_to")]
    public bool? CanInviteTo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_invite_via_email")]
    public bool? CanInviteViaEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_flag_topic")]
    public bool? CanFlagTopic { get; init; }

    [JsonPropertyName("can_convert_topic")]
    public required bool CanConvertTopic { get; init; }

    [JsonPropertyName("can_review_topic")]
    public required bool CanReviewTopic { get; init; }

    [JsonPropertyName("can_close_topic")]
    public required bool CanCloseTopic { get; init; }

    [JsonPropertyName("can_archive_topic")]
    public required bool CanArchiveTopic { get; init; }

    [JsonPropertyName("can_split_merge_topic")]
    public required bool CanSplitMergeTopic { get; init; }

    [JsonPropertyName("can_edit_staff_notes")]
    public required bool CanEditStaffNotes { get; init; }

    [JsonPropertyName("can_toggle_topic_visibility")]
    public required bool CanToggleTopicVisibility { get; init; }

    [JsonPropertyName("can_pin_unpin_topic")]
    public required bool CanPinUnpinTopic { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_banner_topic")]
    public bool? CanBannerTopic { get; init; }

    [JsonPropertyName("can_moderate_category")]
    public required bool CanModerateCategory { get; init; }

    [JsonPropertyName("can_remove_self_id")]
    public required int CanRemoveSelfId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("participants")]
    public IReadOnlyList<Participant1>? Participants { get; init; }

    [JsonPropertyName("created_by")]
    public required CreatedBy CreatedBy { get; init; }

    [JsonPropertyName("last_poster")]
    public required LastPoster LastPoster { get; init; }
}
