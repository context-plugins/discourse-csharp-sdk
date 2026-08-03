using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record ActionsSummary
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("can_act")]
    public required bool CanAct { get; init; }
}
