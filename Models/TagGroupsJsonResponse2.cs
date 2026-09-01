using System.Text.Json.Serialization;
using Discourse.Core.Models;

namespace Discourse.Models;

public record TagGroupsJsonResponse2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tag_group")]
    public TagGroup2? TagGroup { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
