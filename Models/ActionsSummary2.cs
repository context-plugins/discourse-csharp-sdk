using System.Text.Json.Serialization;

namespace DiscourseApiDocumentation.Models;

public record ActionsSummary2
{
    /// <summary>
    /// <c>2</c>: like, <c>3</c>, <c>4</c>, <c>6</c>, <c>7</c>, <c>8</c>: flag
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public int? Count { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acted")]
    public bool? Acted { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_undo")]
    public bool? CanUndo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_act")]
    public bool? CanAct { get; init; }
}
