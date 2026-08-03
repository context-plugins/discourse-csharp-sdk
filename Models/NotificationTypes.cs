using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record NotificationTypes
{
    [JsonPropertyName("mentioned")]
    public required int Mentioned { get; init; }

    [JsonPropertyName("replied")]
    public required int Replied { get; init; }

    [JsonPropertyName("quoted")]
    public required int Quoted { get; init; }

    [JsonPropertyName("edited")]
    public required int Edited { get; init; }

    [JsonPropertyName("liked")]
    public required int Liked { get; init; }

    [JsonPropertyName("private_message")]
    public required int PrivateMessage { get; init; }

    [JsonPropertyName("invited_to_private_message")]
    public required int InvitedToPrivateMessage { get; init; }

    [JsonPropertyName("invitee_accepted")]
    public required int InviteeAccepted { get; init; }

    [JsonPropertyName("posted")]
    public required int Posted { get; init; }

    [JsonPropertyName("watching_category_or_tag")]
    public required int WatchingCategoryOrTag { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_features")]
    public int? NewFeatures { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("admin_problems")]
    public int? AdminProblems { get; init; }

    [JsonPropertyName("moved_post")]
    public required int MovedPost { get; init; }

    [JsonPropertyName("linked")]
    public required int Linked { get; init; }

    [JsonPropertyName("granted_badge")]
    public required int GrantedBadge { get; init; }

    [JsonPropertyName("invited_to_topic")]
    public required int InvitedToTopic { get; init; }

    [JsonPropertyName("custom")]
    public required int Custom { get; init; }

    [JsonPropertyName("group_mentioned")]
    public required int GroupMentioned { get; init; }

    [JsonPropertyName("group_message_summary")]
    public required int GroupMessageSummary { get; init; }

    [JsonPropertyName("watching_first_post")]
    public required int WatchingFirstPost { get; init; }

    [JsonPropertyName("topic_reminder")]
    public required int TopicReminder { get; init; }

    [JsonPropertyName("liked_consolidated")]
    public required int LikedConsolidated { get; init; }

    [JsonPropertyName("linked_consolidated")]
    public required int LinkedConsolidated { get; init; }

    [JsonPropertyName("post_approved")]
    public required int PostApproved { get; init; }

    [JsonPropertyName("code_review_commit_approved")]
    public required int CodeReviewCommitApproved { get; init; }

    [JsonPropertyName("membership_request_accepted")]
    public required int MembershipRequestAccepted { get; init; }

    [JsonPropertyName("membership_request_consolidated")]
    public required int MembershipRequestConsolidated { get; init; }

    [JsonPropertyName("bookmark_reminder")]
    public required int BookmarkReminder { get; init; }

    [JsonPropertyName("reaction")]
    public required int Reaction { get; init; }

    [JsonPropertyName("votes_released")]
    public required int VotesReleased { get; init; }

    [JsonPropertyName("event_reminder")]
    public required int EventReminder { get; init; }

    [JsonPropertyName("event_invitation")]
    public required int EventInvitation { get; init; }

    [JsonPropertyName("chat_mention")]
    public required int ChatMention { get; init; }

    [JsonPropertyName("chat_message")]
    public required int ChatMessage { get; init; }

    [JsonPropertyName("chat_invitation")]
    public required int ChatInvitation { get; init; }

    [JsonPropertyName("chat_group_mention")]
    public required int ChatGroupMention { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chat_quoted")]
    public int? ChatQuoted { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chat_watched_thread")]
    public int? ChatWatchedThread { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upcoming_change_available")]
    public int? UpcomingChangeAvailable { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upcoming_change_automatically_promoted")]
    public int? UpcomingChangeAutomaticallyPromoted { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assigned")]
    public int? Assigned { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("question_answer_user_commented")]
    public int? QuestionAnswerUserCommented { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("following")]
    public int? Following { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("following_created_topic")]
    public int? FollowingCreatedTopic { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("following_replied")]
    public int? FollowingReplied { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("circles_activity")]
    public int? CirclesActivity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("boost")]
    public int? Boost { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suggested_edit_created")]
    public int? SuggestedEditCreated { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suggested_edit_accepted")]
    public int? SuggestedEditAccepted { get; init; }
}
