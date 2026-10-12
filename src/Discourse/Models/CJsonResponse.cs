using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discourse.Models;

public record CJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("users")]
    public IReadOnlyList<User>? Users { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_groups")]
    public IReadOnlyList<object>? PrimaryGroups { get; init; }

    [JsonPropertyName("topic_list")]
    public required TopicList TopicList { get; init; }
}
