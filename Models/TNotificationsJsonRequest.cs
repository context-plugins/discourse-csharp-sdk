using System.Text.Json.Serialization;
using Discourse.Core.Models;
using Discourse.Models.Enums;

namespace Discourse.Models;

public record TNotificationsJsonRequest
{
    [JsonPropertyName("notification_level")]
    public required NotificationLevel NotificationLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
