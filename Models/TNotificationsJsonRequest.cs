using System.Text.Json.Serialization;
using DiscourseApiDocumentation.Core.Models;
using DiscourseApiDocumentation.Models.Enums;

namespace DiscourseApiDocumentation.Models;

public record TNotificationsJsonRequest
{
    [JsonPropertyName("notification_level")]
    public required NotificationLevel NotificationLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
