using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record TJsonRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topic")]
    public Topic5? Topic { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
