using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record TInviteGroupJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    public Group6? Group { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
