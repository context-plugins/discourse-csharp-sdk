using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record TJsonResponse1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("basic_topic")]
    public BasicTopic? BasicTopic { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
