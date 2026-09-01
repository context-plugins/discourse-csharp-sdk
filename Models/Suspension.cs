using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Suspension
{
    [JsonPropertyName("suspend_reason")]
    public required string SuspendReason { get; init; }

    [JsonPropertyName("full_suspend_reason")]
    public required string FullSuspendReason { get; init; }

    [JsonPropertyName("suspended_till")]
    public required string SuspendedTill { get; init; }

    [JsonPropertyName("suspended_at")]
    public required string SuspendedAt { get; init; }

    [JsonPropertyName("suspended_by")]
    public required SuspendedBy SuspendedBy { get; init; }
}
