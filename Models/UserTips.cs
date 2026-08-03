using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record UserTips
{
    [JsonPropertyName("first_notification")]
    public required int FirstNotification { get; init; }

    [JsonPropertyName("topic_timeline")]
    public required int TopicTimeline { get; init; }

    [JsonPropertyName("post_menu")]
    public required int PostMenu { get; init; }

    [JsonPropertyName("topic_notification_levels")]
    public required int TopicNotificationLevels { get; init; }

    [JsonPropertyName("suggested_topics")]
    public required int SuggestedTopics { get; init; }
}
