using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record ActionsSummary5
{
    /// <summary>
    /// ID of the action type (e.g., 2 for like)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    /// <summary>
    /// Number of times this action has been performed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public int? Count { get; init; }

    /// <summary>
    /// Whether the current user has performed this
    /// action
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acted")]
    public bool? Acted { get; init; }

    /// <summary>
    /// Whether the current user can undo this action
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_undo")]
    public bool? CanUndo { get; init; }

    /// <summary>
    /// Whether the current user can perform this action
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_act")]
    public bool? CanAct { get; init; }
}
