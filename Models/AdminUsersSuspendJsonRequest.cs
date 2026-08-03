using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record AdminUsersSuspendJsonRequest
{
    [JsonPropertyName("suspend_until")]
    public required string SuspendUntil { get; init; }

    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    /// <summary>
    /// Will send an email with this message when present
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("post_action")]
    public string? PostAction { get; init; }
}
