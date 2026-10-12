using System.Text.Json.Serialization;

namespace Discourse.Models;

public record CustomFields
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }
}
