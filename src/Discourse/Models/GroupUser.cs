using System.Text.Json.Serialization;

namespace Discourse.Models;

public record GroupUser
{
    [JsonPropertyName("group_id")]
    public required int GroupId { get; init; }

    [JsonPropertyName("user_id")]
    public required int UserId { get; init; }

    [JsonPropertyName("notification_level")]
    public required int NotificationLevel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("owner")]
    public bool? Owner { get; init; }
}
