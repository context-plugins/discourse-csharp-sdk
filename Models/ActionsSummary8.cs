using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record ActionsSummary8
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonPropertyName("hidden")]
    public required bool Hidden { get; init; }

    [JsonPropertyName("can_act")]
    public required bool CanAct { get; init; }
}
