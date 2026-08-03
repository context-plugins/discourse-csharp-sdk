using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record PostActionsJsonRequest
{
    /// <summary>
    /// The ID of the post to perform the action on
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    /// <summary>
    /// The ID of the post action type (e.g., 2 for like)
    /// </summary>
    [JsonPropertyName("post_action_type_id")]
    public required int PostActionTypeId { get; init; }

    /// <summary>
    /// Whether to flag the entire topic
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flag_topic")]
    public bool? FlagTopic { get; init; }
}
