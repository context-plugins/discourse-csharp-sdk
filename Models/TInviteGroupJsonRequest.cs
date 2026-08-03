using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record TInviteGroupJsonRequest
{
    /// <summary>
    /// The name of the group to invite
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    public string? Group { get; init; }

    /// <summary>
    /// Whether to notify the group, it defaults to true
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("should_notify")]
    public bool? ShouldNotify { get; init; }
}
