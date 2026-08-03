using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Models.Enums;

namespace DiscourseApiDocumentation.Models;

public record TNotificationsJsonRequest
{
    [JsonPropertyName("notification_level")]
    public required NotificationLevel NotificationLevel { get; init; }
}
