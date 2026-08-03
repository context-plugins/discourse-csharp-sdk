using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record CategorySetting
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_bump_cooldown_days")]
    public int? AutoBumpCooldownDays { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_auto_bump_daily")]
    public int? NumAutoBumpDaily { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("require_reply_approval")]
    public bool? RequireReplyApproval { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("require_topic_approval")]
    public bool? RequireTopicApproval { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nested_replies_default")]
    public bool? NestedRepliesDefault { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topic_posting_review_mode")]
    public string? TopicPostingReviewMode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reply_posting_review_mode")]
    public string? ReplyPostingReviewMode { get; init; }
}
