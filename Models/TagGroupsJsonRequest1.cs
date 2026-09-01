using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record TagGroupsJsonRequest1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
