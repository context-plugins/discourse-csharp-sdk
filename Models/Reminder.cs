using System.Text.Json.Serialization;
using Discourse.Core.Models;
using Discourse.Models.Enums;

namespace Discourse.Models;

public record Reminder
{
    [JsonPropertyName("value")]
    public required int Value { get; init; }

    [JsonPropertyName("unit")]
    public required string Unit { get; init; }

    [JsonPropertyName("period")]
    public required Period Period { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
