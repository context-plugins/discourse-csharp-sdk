using System.Text.Json.Serialization;

namespace Discourse.Models;

public record Post1
{
    [JsonPropertyName("raw")]
    public required string Raw { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("edit_reason")]
    public string? EditReason { get; init; }
}
