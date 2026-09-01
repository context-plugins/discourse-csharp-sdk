using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Silence
{
    [JsonPropertyName("silenced")]
    public required bool Silenced { get; init; }

    [JsonPropertyName("silence_reason")]
    public required string SilenceReason { get; init; }

    [JsonPropertyName("full_silence_reason")]
    public required string FullSilenceReason { get; init; }

    [JsonPropertyName("silenced_till")]
    public required string SilencedTill { get; init; }

    [JsonPropertyName("silenced_at")]
    public required string SilencedAt { get; init; }

    [JsonPropertyName("silenced_by")]
    public required SilencedBy SilencedBy { get; init; }
}
